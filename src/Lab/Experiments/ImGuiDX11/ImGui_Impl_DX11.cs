// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;
using Silk.NET.Core.Native;
using Silk.NET.Direct3D.Compilers;
using Silk.NET.Direct3D11;
using Silk.NET.DXGI;
using Silk.NET.Maths;

namespace Silk.NET.Lab.Experiments.ImGuiDX11;

public sealed class ImGui_Impl_DX11
{
    private const uint D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = 16u;

    // DirectX11 data
    // Released in ImGui_ImplDX11_Shutdown()
    private ComPtr<ID3D11Device>               pd3dDevice =          default;
    private ComPtr<ID3D11DeviceContext>        pd3dDeviceContext =   default;
    private ComPtr<IDXGIFactory>               pFactory =            default;
    // Released in ImGui_ImplDX11_InvalidateDeviceObjects()
    private ComPtr<ID3D11Buffer>               pVB =                 default;
    private ComPtr<ID3D11Buffer>               pIB =                 default;
    private ComPtr<ID3D11VertexShader>         pVertexShader =       default;
    private ComPtr<ID3D11InputLayout>          pInputLayout =        default;
    private ComPtr<ID3D11Buffer>               pVertexConstantBuffer=default;
    private ComPtr<ID3D11PixelShader>          pPixelShader =        default;    
    private ComPtr<ID3D11RasterizerState>      pRasterizerState =    default;
    private ComPtr<ID3D11BlendState>           pBlendState =         default;
    private ComPtr<ID3D11DepthStencilState>    pDepthStencilState =  default;
    private ComPtr<ID3D11SamplerState>         pFontSampler =        default;
    // Released in ImGui_ImplDX11_DestroyFontsTexture()
    private ComPtr<ID3D11ShaderResourceView>   pFontTextureView =    default;
    
    private int                         vertexBufferSize = 5_000;
    private int                         indexBufferSize = 10_000;
    
    // Do not use BackendRendererUserData, it messed up my pointers randomly
    
    #region Functions

    /// <summary>
    /// Initializes the DirectX11 backend for ImGui.
    /// </summary>
    /// <param name="device">
    /// Pointer to the already initialized D3D11 device.
    /// </param>
    /// <param name="deviceContext">
    /// Pointer to the already initialized D3D11 device context.
    /// </param>
    /// <returns>
    /// True if the initialization was successful, throws otherwise.
    /// </returns>
    public unsafe bool ImGui_ImplDX11_Init(ID3D11Device* device, ID3D11DeviceContext* deviceContext)
    {
        ImGuiIOPtr io = ImGui.GetIO();
        
        // TODO: Check version macro
        // IMGUI_CHECKVERSION();
        // Debug.Assert(io.BackendRendererUserData == IntPtr.Zero, "Already initialized a renderer backend!");

        // Setup backend capabilities flags
        // Do not use BackendRendererUserData it messed my pointers randomly
        io.BackendFlags |= ImGuiBackendFlags.RendererHasVtxOffset;  // We can honor the ImDrawCmd::VtxOffset field, allowing for large meshes.

        // Get factory from device
        ComPtr<IDXGIDevice> pDXGIDevice = default;
        ComPtr<IDXGIAdapter> pDXGIAdapter = default;
        ComPtr<IDXGIFactory> pFactory = default;

        if (device->QueryInterface(out pDXGIDevice) == 0)
        {
            if (pDXGIDevice.GetParent(out pDXGIAdapter) == 0)
            {
                if (pDXGIAdapter.GetParent(out pFactory) == 0)
                {
                    pd3dDevice = device;
                    pd3dDeviceContext = deviceContext;
                    this.pFactory = pFactory;
                }
            }
        }
        pDXGIDevice.Release();
        pDXGIAdapter.Release();
        pd3dDevice.AddRef();
        pd3dDeviceContext.AddRef();

        return true;
    }
    
    /// <summary>
    /// Creates all required DX11 resources for ImGui.
    /// </summary>
    /// <returns>
    /// True if the resources were created successfully, false otherwise.
    /// </returns>
    internal unsafe bool ImGui_ImplDX11_CreateDeviceObjects()
    {
        if ((long)pd3dDevice.Handle == 0)
            return false;
        if ((long)pFontSampler.Handle != 0)
            ImGui_ImplDX11_InvalidateDeviceObjects();

        // By using D3DCompile() from <d3dcompiler.h> / d3dcompiler.lib, we introduce a dependency to a given version of d3dcompiler_XX.dll (see D3DCOMPILER_DLL_A)
        // If you would like to use this DX11 sample code but remove this dependency you can:
        //  1) compile once, save the compiled shader blobs into a file or source code and pass them to CreateVertexShader()/CreatePixelShader() [preferred solution]
        //  2) use code to detect any version of the DLL and grab a pointer to D3DCompile from the DLL.
        // See https://github.com/ocornut/imgui/pull/638 for sources and details.
        D3DCompiler compiler = D3DCompiler.GetApi();

        // Create the vertex shader
        string vertexShader =
            @"cbuffer vertexBuffer : register(b0)
            {
              float4x4 ProjectionMatrix;
            };
            struct VS_INPUT
            {
              float2 pos : POSITION;
              float4 col : COLOR0;
              float2 uv  : TEXCOORD0;
            };
            
            struct PS_INPUT
            {
              float4 pos : SV_POSITION;
              float4 col : COLOR0;
              float2 uv  : TEXCOORD0;
            };
            
            PS_INPUT main(VS_INPUT input)
            {
              PS_INPUT output;
              output.pos = mul( ProjectionMatrix, float4(input.pos.xy, 0.f, 1.f));
              output.col = input.col;
              output.uv  = input.uv;
              return output;
            }";

        ComPtr<ID3D10Blob> vertexShaderBlob = default;
        ComPtr<ID3D10Blob> errorBlob = default;
        byte[] shaderBytes = Encoding.ASCII.GetBytes(vertexShader);
        HResult hr = compiler.Compile(
            in shaderBytes[0],
            (nuint) shaderBytes.Length,
            nameof(vertexShader),
            null,
            ref Unsafe.NullRef<ID3DInclude>(),
            "main",
            "vs_4_0",
            0,
            0,
            ref vertexShaderBlob,
            ref errorBlob);
        if (hr.IsFailure)
        {
            if (errorBlob.Handle is not null)
            {
                Console.WriteLine(SilkMarshal.PtrToString((nint) errorBlob.GetBufferPointer()));
            }
            hr.Throw();
            return false; // NB: Pass ID3DBlob* pErrorBlob to D3DCompile() to get error showing in (const char*)pErrorBlob->GetBufferPointer(). Make sure to Release() the blob!
        }
        try
        {
            SilkMarshal.ThrowHResult(
                pd3dDevice.CreateVertexShader(vertexShaderBlob.GetBufferPointer(), vertexShaderBlob.GetBufferSize(),
                    ref Unsafe.NullRef<ID3D11ClassLinkage>(), ref pVertexShader));
        }
        catch
        {
            vertexShaderBlob.Release();
            throw;
        }

        fixed (byte* pos = SilkMarshal.StringToMemory("POSITION"))
        fixed (byte* uv = SilkMarshal.StringToMemory("TEXCOORD"))
        fixed (byte* col = SilkMarshal.StringToMemory("COLOR"))
        {
            // Create the input layout
            ReadOnlySpan<InputElementDesc> local_layout = new[]{
                new InputElementDesc()
                {
                    SemanticName = pos,
                    SemanticIndex = 0,
                    Format = Format.FormatR32G32Float,
                    InputSlot = 0,
                    AlignedByteOffset = (uint)Marshal.OffsetOf<ImDrawVert>(nameof(ImDrawVert.pos)),
                    InputSlotClass = InputClassification.PerVertexData,
                    InstanceDataStepRate = 0
                },
                new InputElementDesc()
                {
                    SemanticName = uv,
                    SemanticIndex = 0,
                    Format = Format.FormatR32G32Float,
                    InputSlot = 0,
                    AlignedByteOffset = (uint)Marshal.OffsetOf<ImDrawVert>(nameof(ImDrawVert.uv)),
                    InputSlotClass = InputClassification.PerVertexData,
                    InstanceDataStepRate = 0
                },
                new InputElementDesc()
                {
                    SemanticName = col,
                    SemanticIndex = 0,
                    Format = Format.FormatR8G8B8A8Unorm,
                    InputSlot = 0,
                    AlignedByteOffset = (uint)Marshal.OffsetOf<ImDrawVert>(nameof(ImDrawVert.col)),
                    InputSlotClass = InputClassification.PerVertexData,
                    InstanceDataStepRate = 0
                },
            };
            try
            {
                SilkMarshal.ThrowHResult(
                    pd3dDevice.CreateInputLayout(local_layout, 3,
                        vertexShaderBlob.GetBufferPointer(), (uint)vertexShaderBlob.GetBufferSize(),
                        pInputLayout.GetAddressOf()));
            }
            catch
            {
                vertexShaderBlob.Release();
                throw;
            }
        }
        vertexShaderBlob.Release();
        // Release the error blob
        errorBlob.Release();

        // Create the constant buffer
        BufferDesc desc = new BufferDesc
        {
            ByteWidth = (uint)sizeof(VERTEX_CONSTANT_BUFFER_DX11),
            Usage = Usage.Dynamic,
            BindFlags = (uint)BindFlag.ConstantBuffer,
            CPUAccessFlags = (uint)CpuAccessFlag.Write,
            MiscFlags = 0
        };
        SilkMarshal.ThrowHResult(
            pd3dDevice.CreateBuffer(in desc, null, ref pVertexConstantBuffer));

        // Create the pixel shader
        string pixelShader =
            @"struct PS_INPUT
            {
            float4 pos : SV_POSITION;
            float4 col : COLOR0;
            float2 uv  : TEXCOORD0;
            };
            sampler sampler0;
            Texture2D texture0;
            
            float4 main(PS_INPUT input) : SV_Target
            {
            float4 out_col = input.col * texture0.Sample(sampler0, input.uv);
            return out_col;
            }";

        ComPtr<ID3D10Blob> pixelShaderBlob = default;
        errorBlob = null;
        shaderBytes = Encoding.ASCII.GetBytes(pixelShader);
        hr = compiler.Compile(
            in shaderBytes[0],
            (nuint) shaderBytes.Length,
            nameof(pixelShader),
            null,
            ref Unsafe.NullRef<ID3DInclude>(),
            "main",
            "ps_4_0",
            0,
            0,
            ref pixelShaderBlob,
            ref errorBlob);
        if (hr.IsFailure)
        {
            if (errorBlob.Handle is not null)
            {
                Console.WriteLine(SilkMarshal.PtrToString((nint) errorBlob.GetBufferPointer()));
            }
            hr.Throw();
            return false; // NB: Pass ID3DBlob* pErrorBlob to D3DCompile() to get error showing in (const char*)pErrorBlob->GetBufferPointer(). Make sure to Release() the blob!
        }

        try
        {
            SilkMarshal.ThrowHResult(
                pd3dDevice.CreatePixelShader(pixelShaderBlob.GetBufferPointer(), pixelShaderBlob.GetBufferSize(),
                    ref Unsafe.NullRef<ID3D11ClassLinkage>(), ref pPixelShader));
        }
        catch
        {
            pixelShaderBlob.Release();
            throw;
        }
        // TODO: Can be improved by using a try-finally block
        pixelShaderBlob.Release();
        // Release the error blob
        errorBlob.Release();

        // Create the blending setup
        BlendDesc blendDesc = new BlendDesc
        {
            AlphaToCoverageEnable = false,
            RenderTarget = new BlendDesc.RenderTargetBuffer()
            {
                Element0 = new RenderTargetBlendDesc()
                {
                    BlendEnable = true,
                    SrcBlend = Blend.SrcAlpha,
                    DestBlend = Blend.InvSrcAlpha,
                    BlendOp = BlendOp.Add,
                    SrcBlendAlpha = Blend.One,
                    DestBlendAlpha = Blend.InvSrcAlpha,
                    BlendOpAlpha = BlendOp.Add,
                    RenderTargetWriteMask = (byte)ColorWriteEnable.All,
                }
            }
        };
        SilkMarshal.ThrowHResult(
            pd3dDevice.CreateBlendState(in blendDesc, ref pBlendState));

        // Create the rasterizer state
        RasterizerDesc rasterizerDesc = new RasterizerDesc
        {
            FillMode = FillMode.Solid,
            CullMode = CullMode.None,
            ScissorEnable = true,
            DepthClipEnable = true
        };
        SilkMarshal.ThrowHResult(
            pd3dDevice.CreateRasterizerState(in rasterizerDesc, ref pRasterizerState));

        // Create depth-stencil State
        DepthStencilDesc depthStencilDesc = new DepthStencilDesc
        {
            DepthEnable = false,
            DepthWriteMask = DepthWriteMask.All,
            DepthFunc = ComparisonFunc.Always,
            StencilEnable = false,
            FrontFace = new DepthStencilopDesc()
            {
                StencilFailOp = StencilOp.Keep,
                StencilDepthFailOp = StencilOp.Keep,
                StencilPassOp = StencilOp.Keep,
                StencilFunc = ComparisonFunc.Always
            },
        };
        depthStencilDesc.BackFace = depthStencilDesc.FrontFace;
        SilkMarshal.ThrowHResult(
            pd3dDevice.CreateDepthStencilState(in depthStencilDesc, ref pDepthStencilState));

        // Create texture sampler
        // (Bilinear sampling is required by default. Set 'io.Fonts->Flags |= ImFontAtlasFlags_NoBakedLines' or 'style.AntiAliasedLinesUseTex = false' to allow point/nearest sampling)
        SamplerDesc samplerDesc = new SamplerDesc
        {
            Filter = Filter.MinMagMipLinear,
            AddressU = TextureAddressMode.Clamp,
            AddressV = TextureAddressMode.Clamp,
            AddressW = TextureAddressMode.Clamp,
            MipLODBias = 0f,
            ComparisonFunc = ComparisonFunc.Always,
            MinLOD = 0f,
            MaxLOD = 0f
        };
        SilkMarshal.ThrowHResult(
            pd3dDevice.CreateSamplerState(in samplerDesc, ref pFontSampler));

        ImGui_ImplDX11_CreateFontsTexture();

        return true;
    }
    
    /// <summary>
    /// Setups basic/defaults DX11 bindings/state.
    /// </summary>
    /// <param name="displaySize">
    /// Size of the display for viewport setup.
    /// </param>
    private unsafe void ImGui_ImplDX11_SetupRenderState(Vector2 displaySize)
    {
        // Setup viewport
        Viewport vp = new Viewport
        {
            Width = displaySize.X,
            Height = displaySize.Y,
            MinDepth = 0.0f,
            MaxDepth = 1.0f
        };
        vp.TopLeftX = vp.TopLeftY = 0;
        pd3dDeviceContext.RSSetViewports(1, in vp);

        // Setup shader and vertex buffers
        uint stride = (uint)sizeof(ImDrawVert);
        uint offset = 0;
        
        pd3dDeviceContext.IASetInputLayout(pInputLayout);
        pd3dDeviceContext.IASetVertexBuffers(0, 1, ref pVB, in stride, in offset);
        // WARNING there, ImDrawIdx is not defined by ImGui.NET, and uses R16_UINT by default (16-bit indices, aka ushort)
        // Using R32_UINT would require recompiling cimgui with the correct define
        // See https://github.com/ImGuiNET/ImGui.NET/issues/248
        // Original code: https://github.com/ocornut/imgui/blob/v1.91.6/imgui.h#L259
        pd3dDeviceContext.IASetIndexBuffer(pIB, Format.FormatR16Uint, 0);
        pd3dDeviceContext.IASetPrimitiveTopology(D3DPrimitiveTopology.D3D11PrimitiveTopologyTrianglelist);
        pd3dDeviceContext.VSSetShader(pVertexShader, null, 0);
        pd3dDeviceContext.VSSetConstantBuffers(0, 1, ref pVertexConstantBuffer);
        pd3dDeviceContext.PSSetShader(pPixelShader, null, 0);
        pd3dDeviceContext.PSSetSamplers(0, 1, ref pFontSampler);
        pd3dDeviceContext.GSSetShader(ref Unsafe.NullRef<ID3D11GeometryShader>(), null, 0);
        pd3dDeviceContext.HSSetShader(ref Unsafe.NullRef<ID3D11HullShader>(), null, 0); // In theory we should backup and restore this as well.. very infrequently used..
        pd3dDeviceContext.DSSetShader(ref Unsafe.NullRef<ID3D11DomainShader>(), null, 0); // In theory we should backup and restore this as well.. very infrequently used..
        pd3dDeviceContext.CSSetShader(ref Unsafe.NullRef<ID3D11ComputeShader>(), null, 0); // In theory we should backup and restore this as well.. very infrequently used..

        // Setup blend state
        float[] blendFactor = {0f, 0f, 0f, 0f};
        fixed (float* blendFactorPtr = blendFactor)
        {
            pd3dDeviceContext.OMSetBlendState(pBlendState, blendFactorPtr, 0xffffffff);
        }
        pd3dDeviceContext.OMSetDepthStencilState(pDepthStencilState, 0);
        pd3dDeviceContext.RSSetState(pRasterizerState);
    }
    
    /// <summary>
    /// Renders the raw ImGui draw data.
    /// <see cref="ImGui_ImplDX11_Init"/> and <see cref="ImGui_ImplDX11_CreateDeviceObjects"/> must have been called first.
    /// </summary>
    /// <param name="drawDataPtr">
    /// ImGui draw data to send to the graphics pipeline to render.
    /// </param>
    /// <exception cref="NotImplementedException">
    /// User callbacks are not implemented and will throw.
    /// </exception>
    public unsafe void ImGui_ImplDX11_RenderDrawData(ImDrawDataPtr drawDataPtr)
    {
        // Avoid rendering when minimized
        if (drawDataPtr.DisplaySize.X <= 0.0f || drawDataPtr.DisplaySize.Y <= 0.0f)
            return;

        // Create and grow vertex/index buffers if needed
        if ((long)pVB.Handle == 0 || vertexBufferSize < drawDataPtr.TotalVtxCount)
        {
            // Looks like it is never called, but there's an OR gate right above
            if ((long)pVB.Handle != 0)
            {
                pVB.Release();
                pVB = null;
            }
            vertexBufferSize = drawDataPtr.TotalVtxCount + 5000;
            BufferDesc desc = new BufferDesc
            {
                Usage = Usage.Dynamic,
                ByteWidth = (uint)(vertexBufferSize * sizeof(ImDrawVert)),
                BindFlags = (uint)BindFlag.VertexBuffer,
                CPUAccessFlags = (uint)CpuAccessFlag.Write,
                MiscFlags = 0
            };
            SilkMarshal.ThrowHResult(
                pd3dDevice.CreateBuffer(in desc, null, ref pVB));
        }
        if ((long)pIB.Handle == 0 || indexBufferSize < drawDataPtr.TotalIdxCount)
        {
            // Looks like it is never called, but there's an OR gate right above
            if ((long)pIB.Handle != 0)
            {
                pIB.Release();
                pIB = null;
            }
            indexBufferSize = drawDataPtr.TotalIdxCount + 10000;
            BufferDesc desc = new BufferDesc
            {
                Usage = Usage.Dynamic,
                ByteWidth = (uint)(indexBufferSize * sizeof(ushort)),
                BindFlags = (uint)BindFlag.IndexBuffer,
                CPUAccessFlags = (uint)CpuAccessFlag.Write
            };
            SilkMarshal.ThrowHResult(
                pd3dDevice.CreateBuffer(in desc, null, ref pIB));
        }

        // Upload vertex/index data into a single contiguous GPU buffer
        MappedSubresource vtxResource = default;
        MappedSubresource idxResource = default;
        SilkMarshal.ThrowHResult(
            pd3dDeviceContext.Map(pVB, 0, Map.WriteDiscard, 0, ref vtxResource));
        SilkMarshal.ThrowHResult(
            pd3dDeviceContext.Map(pIB, 0, Map.WriteDiscard, 0, ref idxResource));
        // TODO: Check those casts, should be fine but idk
        ImDrawVert* vtxDstResource = (ImDrawVert*)vtxResource.PData;
        ushort* idxDstResource = (ushort*)idxResource.PData;
        for (int n = 0; n < drawDataPtr.CmdListsCount; n++)
        {
            ImDrawListPtr drawListPtr = drawDataPtr.CmdLists[n];
            Unsafe.CopyBlock(vtxDstResource, drawListPtr.VtxBuffer.Data.ToPointer(), (uint)(drawListPtr.VtxBuffer.Size * sizeof(ImDrawVert)));
            Unsafe.CopyBlock(idxDstResource, drawListPtr.IdxBuffer.Data.ToPointer(), (uint)(drawListPtr.IdxBuffer.Size * sizeof(ushort)));
            vtxDstResource += drawListPtr.VtxBuffer.Size;
            idxDstResource += drawListPtr.IdxBuffer.Size;
        }
        pd3dDeviceContext.Unmap(pVB, 0);
        pd3dDeviceContext.Unmap(pIB, 0);

        // Setup orthographic projection matrix into our constant buffer
        // Our visible imgui space lies from draw_data->DisplayPos (top left) to draw_data->DisplayPos+data_data->DisplaySize (bottom right). DisplayPos is (0,0) for single viewport apps.
        MappedSubresource mappedResource = default;
        SilkMarshal.ThrowHResult(
            pd3dDeviceContext.Map(pVertexConstantBuffer, 0, Map.WriteDiscard, 0, ref mappedResource));
        VERTEX_CONSTANT_BUFFER_DX11* constantBuffer = (VERTEX_CONSTANT_BUFFER_DX11*)mappedResource.PData;
        float L = drawDataPtr.DisplayPos.X;
        float R = drawDataPtr.DisplayPos.X + drawDataPtr.DisplaySize.X;
        float T = drawDataPtr.DisplayPos.Y;
        float B = drawDataPtr.DisplayPos.Y + drawDataPtr.DisplaySize.Y;
        Matrix4X4<float> mvp = new Matrix4X4<float>(
            2.0f / (R - L), 0.0f, 0.0f, 0.0f,
            0.0f, 2.0f / (T - B), 0.0f, 0.0f,
            0.0f, 0.0f, 0.5f, 0.0f,
            (R + L) / (L - R), (T + B) / (B - T), 0.5f, 1.0f
        );
        Unsafe.CopyBlock(Unsafe.AsPointer(ref constantBuffer->mvp), Unsafe.AsPointer(ref mvp), (uint)sizeof(Matrix4X4<float>));
        pd3dDeviceContext.Unmap(pVertexConstantBuffer, 0);

        // Backup previous DX11 state
        BACKUP_DX11_STATE old = new BACKUP_DX11_STATE();
        old.ScissorRectsCount = old.ViewportsCount = D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE;
        pd3dDeviceContext.RSGetScissorRects(ref old.ScissorRectsCount, old.ScissorRects);
        pd3dDeviceContext.RSGetViewports(ref old.ViewportsCount, old.Viewports);
        pd3dDeviceContext.RSGetState(ref old.RS);
        pd3dDeviceContext.OMGetBlendState(ref old.BlendState, old.BlendFactor, ref old.SampleMask);
        pd3dDeviceContext.OMGetDepthStencilState(ref old.DepthStencilState, ref old.StencilRef);
        pd3dDeviceContext.PSGetShaderResources(0, 1, ref old.PSShaderResource);
        pd3dDeviceContext.PSGetSamplers(0, 1, ref old.PSSampler);
        old.PSInstancesCount = old.VSInstancesCount = old.GSInstancesCount = 256;
        pd3dDeviceContext.PSGetShader(ref old.PS, ref old.PSInstances, ref old.PSInstancesCount);
        pd3dDeviceContext.VSGetShader(ref old.VS, ref old.VSInstances, ref old.VSInstancesCount);
        pd3dDeviceContext.VSGetConstantBuffers(0, 1, ref old.VSConstantBuffer);
        pd3dDeviceContext.GSGetShader(ref old.GS, ref old.GSInstances, ref old.GSInstancesCount);
        
        pd3dDeviceContext.IAGetPrimitiveTopology(ref old.PrimitiveTopology);
        pd3dDeviceContext.IAGetIndexBuffer(ref old.IndexBuffer, ref old.IndexBufferFormat, ref old.IndexBufferOffset);
        pd3dDeviceContext.IAGetVertexBuffers(0, 1, ref old.VertexBuffer, ref old.VertexBufferStride, ref old.VertexBufferOffset);
        pd3dDeviceContext.IAGetInputLayout(ref old.InputLayout);

        // Setup desired DX state
        ImGui_ImplDX11_SetupRenderState(drawDataPtr.DisplaySize);

        // Render command lists
        // (Because we merged all buffers into a single one, we maintain our own offset into them)
        int globalIdxOffset = 0;
        int globalVtxOffset = 0;
        Vector2 clipOff = drawDataPtr.DisplayPos;
        for (int n = 0; n < drawDataPtr.CmdListsCount; n++)
        {
            ImDrawListPtr drawListPtr = drawDataPtr.CmdLists[n];
            for (int cmd_i = 0; cmd_i < drawListPtr.CmdBuffer.Size; cmd_i++)
            {
                ImDrawCmdPtr drawCmdPtr = drawListPtr.CmdBuffer[cmd_i];
                if ((long)drawCmdPtr.UserCallback != 0)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    // Project scissor/clipping rectangles into framebuffer space
                    Vector2D<float> clipMin = new Vector2D<float>(drawCmdPtr.ClipRect.X - clipOff.X, drawCmdPtr.ClipRect.Y - clipOff.Y);
                    Vector2D<float> clipMax = new Vector2D<float>(drawCmdPtr.ClipRect.Z - clipOff.X, drawCmdPtr.ClipRect.W - clipOff.Y);
                    if (clipMax.X <= clipMin.X || clipMax.Y <= clipMin.Y)
                        continue;

                    // Apply scissor/clipping rectangle
                    Box2D<int> r = new Box2D<int>((int)clipMin.X, (int)clipMin.Y, (int)clipMax.X, (int)clipMax.Y);
                    pd3dDeviceContext.RSSetScissorRects(1, in r);

                    // Bind texture, Draw
                    // Moved this line out of the for loop since it caused issues
                    // ID3D11ShaderResourceView* texture_srv = (ID3D11ShaderResourceView*)pcmd.TextureId;
                    // pd3dDeviceContext.PSSetShaderResources(0, 1, &texture_srv);
                    pd3dDeviceContext.DrawIndexed(drawCmdPtr.ElemCount, (uint)(drawCmdPtr.IdxOffset + globalIdxOffset), (int)(drawCmdPtr.VtxOffset + globalVtxOffset));
                }
            }
            globalIdxOffset += drawListPtr.IdxBuffer.Size;
            globalVtxOffset += drawListPtr.VtxBuffer.Size;
        }
        // Moved font texture binding out of the for loop
        pd3dDeviceContext.PSSetShaderResources(0u, 1u, ref pFontTextureView);

        // Restore modified DX state
        pd3dDeviceContext.RSSetScissorRects(old.ScissorRectsCount, old.ScissorRects);
        // TODO: Solve viewports issue, throws nullptrException
        // pd3dDeviceContext.RSSetViewports(old.ViewportsCount, old.Viewports);
        pd3dDeviceContext.RSSetState(old.RS);
        if (old.RS != null) old.RS->Release();
        pd3dDeviceContext.OMSetBlendState(old.BlendState, old.BlendFactor, old.SampleMask);
        if (old.BlendState != null) old.BlendState->Release();
        pd3dDeviceContext.OMSetDepthStencilState(old.DepthStencilState, old.StencilRef);
        if (old.DepthStencilState != null) old.DepthStencilState->Release();
        pd3dDeviceContext.PSSetShaderResources(0, 1, in old.PSShaderResource);
        if (old.PSShaderResource != null) old.PSShaderResource->Release();
        pd3dDeviceContext.PSSetSamplers(0, 1, in old.PSSampler);
        if (old.PSSampler != null) old.PSSampler->Release();
        pd3dDeviceContext.PSSetShader(old.PS, old.PSInstances, old.PSInstancesCount);
        if (old.PS != null) old.PS->Release();
        if (old.PSInstances.Handle != null) old.PSInstances.Release();
        pd3dDeviceContext.VSSetShader(old.VS, old.VSInstances, old.VSInstancesCount);
        if (old.VS != null) old.VS->Release();
        if (old.VSInstances.Handle != null) old.VSInstances.Release();
        pd3dDeviceContext.VSSetConstantBuffers(0, 1, in old.VSConstantBuffer);
        if (old.VSConstantBuffer != null) old.VSConstantBuffer->Release();
        pd3dDeviceContext.GSSetShader(old.GS, old.GSInstances, old.GSInstancesCount);
        if (old.GS != null) old.GS->Release();
        if (old.GSInstances.Handle != null) old.GSInstances.Release();
        pd3dDeviceContext.IASetPrimitiveTopology(old.PrimitiveTopology);
        pd3dDeviceContext.IASetIndexBuffer(old.IndexBuffer, old.IndexBufferFormat, old.IndexBufferOffset);
        if (old.IndexBuffer != null) old.IndexBuffer->Release();
        pd3dDeviceContext.IASetVertexBuffers(0, 1, in old.VertexBuffer, in old.VertexBufferStride, in old.VertexBufferOffset);
        if (old.VertexBuffer != null) old.VertexBuffer->Release();
        pd3dDeviceContext.IASetInputLayout(old.InputLayout);
        if (old.InputLayout != null) old.InputLayout->Release();
    }
    
    /// <summary>
    /// Creates the texture for the font atlas, retrieves it from ImGui and uploads it to the graphics system
    /// </summary>
    private unsafe void ImGui_ImplDX11_CreateFontsTexture()
    {
        // Build texture atlas
        ImGuiIOPtr io = ImGui.GetIO();
        io.Fonts.GetTexDataAsRGBA32(out byte* pixels,out int width, out int height);

        // Upload texture to graphics system
        Texture2DDesc desc = new Texture2DDesc
        {
            Width = (uint)width,
            Height = (uint)height,
            MipLevels = 1,
            ArraySize = 1,
            Format = Format.FormatR8G8B8A8Unorm,
            SampleDesc = new SampleDesc()
            {
                Count = 1,
            },
            Usage = Usage.Default,
            BindFlags = (uint)BindFlag.ShaderResource,
            CPUAccessFlags = 0,
        };

        ComPtr<ID3D11Texture2D> pTexture = default;
        SubresourceData subResource = new SubresourceData
        {
            PSysMem = pixels,
            SysMemPitch = desc.Width * 4,
            SysMemSlicePitch = 0
        };
        SilkMarshal.ThrowHResult(
            pd3dDevice.CreateTexture2D(in desc, in subResource, ref pTexture));
        Debug.Assert(pTexture.Handle != null);

        // Create texture view
        ShaderResourceViewDesc srvDesc = new ShaderResourceViewDesc
        {
            Format = Format.FormatR8G8B8A8Unorm,
            ViewDimension = D3DSrvDimension.D3D11SrvDimensionTexture2D,
            Texture2D = new Tex2DSrv()
            {
                MipLevels = desc.MipLevels,
                MostDetailedMip = 0,
            },
        };
        SilkMarshal.ThrowHResult(
            pd3dDevice.CreateShaderResourceView(pTexture, in srvDesc, ref pFontTextureView));
        pTexture.Release();

        // Store our identifier, not useful, but we keep it anyway
        io.Fonts.SetTexID((IntPtr)pFontTextureView.Handle);
        // Not sure where to put it, removed it from cmd buffers
        pd3dDeviceContext.PSSetShaderResources(0, 1, ref pFontTextureView);
    }
    
    /// <summary>
    /// Destroys the font texture and clears the font texture view.
    /// </summary>
    private unsafe void ImGui_ImplDX11_DestroyFontsTexture()
    {
        if ((long)pFontTextureView.Handle != 0)
        {
            pFontTextureView.Release();
            pFontTextureView = null;
            ImGui.GetIO().Fonts.SetTexID(IntPtr.Zero); // We copied data->pFontTextureView to io.Fonts->TexID so let's clear that as well.
        }
    }
    
    /// <summary>
    /// Releases D3D11 resources created by <see cref="ImGui_ImplDX11_CreateDeviceObjects"/>.
    /// </summary>
    private unsafe void ImGui_ImplDX11_InvalidateDeviceObjects()
    {
        if ((long)pd3dDevice.Handle == 0)
            return;

        ImGui_ImplDX11_DestroyFontsTexture();

        pFontSampler.Release();
        pFontSampler = null;
        pIB.Release();
        pIB = null;
        pVB.Release();
        pVB = null;
        pBlendState.Release();
        pBlendState = null;
        pDepthStencilState.Release();
        pDepthStencilState = null;
        pRasterizerState.Release();
        pRasterizerState = null;
        pPixelShader.Release();
        pPixelShader = null;
        pVertexConstantBuffer.Release();
        pVertexConstantBuffer = null;
        pInputLayout.Release();
        pInputLayout = null;
        pVertexShader.Release();
        pVertexShader = null;
    }

    public void ImGui_ImplDX11_Shutdown()
    {
        ImGuiIOPtr io = ImGui.GetIO();

        ImGui_ImplDX11_InvalidateDeviceObjects();
        pFactory.Release();
        pd3dDevice.Release();
        pd3dDeviceContext.Release();
        
        io.BackendRendererUserData = IntPtr.Zero;
        io.BackendFlags &= ~ImGuiBackendFlags.RendererHasVtxOffset;
    }
    
    #endregion
    
    #region Structs

    struct VERTEX_CONSTANT_BUFFER_DX11
    {
        public Matrix4X4<float> mvp;
    }
    
    // Backup DX state that will be modified to restore it afterward (unfortunately this is very ugly looking and verbose. Close your eyes!)
    // I added some pointers to pass arrays of instances where I thought it was needed
    unsafe struct BACKUP_DX11_STATE
    {
        public uint                        ScissorRectsCount, ViewportsCount;
        public Box2D<int>*                 ScissorRects;
        public Viewport*                   Viewports;
        public ID3D11RasterizerState*      RS;
        public ID3D11BlendState*           BlendState;
        public float*                      BlendFactor;
        public uint                        SampleMask;
        public uint                        StencilRef;
        public ID3D11DepthStencilState*    DepthStencilState;
        public ID3D11ShaderResourceView*   PSShaderResource;
        public ID3D11SamplerState*         PSSampler;
        public ID3D11PixelShader*          PS;
        public ID3D11VertexShader*         VS;
        public ID3D11GeometryShader*       GS;
        public uint                        PSInstancesCount, VSInstancesCount, GSInstancesCount;
        public ComPtr<ID3D11ClassInstance> PSInstances, VSInstances, GSInstances;   // 256 is max according to PSSetShader documentation
        public D3DPrimitiveTopology        PrimitiveTopology;
        public ID3D11Buffer*               IndexBuffer, VertexBuffer, VSConstantBuffer;
        public uint                        IndexBufferOffset, VertexBufferStride, VertexBufferOffset;
        public Format                      IndexBufferFormat;
        public ID3D11InputLayout*          InputLayout;
    }
    
    #endregion
}
