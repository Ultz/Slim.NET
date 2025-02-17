// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using ImGuiNET;
using Silk.NET.Direct3D11;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace Silk.NET.Lab.Experiments.ImGuiDX11;

public class ImGuiDX11Controller
{
    private ImGui_Impl_DX11 instance;
    private IView _view;
    private IInputContext _input;
    private bool _frameBegun;
    private readonly List<char> _pressedChars = new();
    private IKeyboard _keyboard;

    private int _windowWidth;
    private int _windowHeight;

    public IntPtr ImGuiContext;

    // TODO: Implement overloads for all numbered types of ID3D11Device and ID3D11DeviceContext
    /// <summary>
    /// Constructs a new ImGuiController with font configuration and onConfigure Action.
    /// </summary>
    public unsafe ImGuiDX11Controller(ID3D11Device* device, ID3D11DeviceContext* deviceContext,
        IView view, IInputContext input,
        ImGuiFontConfig? imGuiFontConfig = null, Action onConfigureIO = null)
    {
        instance = new ImGui_Impl_DX11();
        Init(view, input);

        ImGuiIOPtr io = ImGui.GetIO();
        if (imGuiFontConfig is not null)
        {
            IntPtr glyphRange = imGuiFontConfig.Value.GetGlyphRange?.Invoke(io) ?? default(IntPtr);

            io.Fonts.AddFontFromFileTTF(imGuiFontConfig.Value.FontPath, imGuiFontConfig.Value.FontSize, null, glyphRange);
        }

        onConfigureIO?.Invoke();

        io.BackendFlags |= ImGuiBackendFlags.RendererHasVtxOffset;
        
        // From ImGui_Impl_win32
        ImGuiViewportPtr mainViewport = ImGui.GetMainViewport();
        mainViewport.PlatformHandle = view.Native!.DXHandle!.Value;
        mainViewport.PlatformHandleRaw = view.Native!.DXHandle!.Value;

        if (!instance.ImGui_ImplDX11_Init(device, deviceContext))
        {
            throw new Exception("Failed to initialize ImGui DX11");
        }
        if (!instance.ImGui_ImplDX11_CreateDeviceObjects())
        {
            throw new Exception("Failed to create ImGui DX11 device objects");
        }

        SetPerFrameImGuiData(1f / 60f);

        BeginFrame();
    }

    private void Init(IView view, IInputContext input)
    {
        _view = view;
        _input = input;
        _windowWidth = view.FramebufferSize.X;
        _windowHeight = view.FramebufferSize.Y;

        ImGuiContext = ImGui.CreateContext();
        ImGui.SetCurrentContext(ImGuiContext);
        ImGui.StyleColorsDark();
    }

    private void BeginFrame()
    {
        ImGui.NewFrame();
        _frameBegun = true;
        _keyboard = _input.Keyboards[0];
        _view.Resize += WindowResized;
        _keyboard.KeyDown += OnKeyDown;
        _keyboard.KeyUp += OnKeyUp;
        _keyboard.KeyChar += OnKeyChar;
    }

    /// <summary>
    /// Delegate to receive keyboard key down events.
    /// </summary>
    /// <param name="keyboard">The keyboard context generating the event.</param>
    /// <param name="keycode">The native keycode of the pressed key.</param>
    /// <param name="scancode">The native scancode of the pressed key.</param>
    private static void OnKeyDown(IKeyboard keyboard, Key keycode, int scancode) =>
        OnKeyEvent(keyboard, keycode, scancode, down: true);

    /// <summary>
    /// Delegate to receive keyboard key up events.
    /// </summary>
    /// <param name="keyboard">The keyboard context generating the event.</param>
    /// <param name="keycode">The native keycode of the released key.</param>
    /// <param name="scancode">The native scancode of the released key.</param>
    private static void OnKeyUp(IKeyboard keyboard, Key keycode, int scancode) =>
        OnKeyEvent(keyboard, keycode, scancode, down: false);

    /// <summary>
    /// Delegate to receive keyboard key events.
    /// </summary>
    /// <param name="keyboard">The keyboard context generating the event.</param>
    /// <param name="keycode">The native keycode of the key generating the event.</param>
    /// <param name="scancode">The native scancode of the key generating the event.</param>
    /// <param name="down">True if the event is a key down event, otherwise False</param>
    private static void OnKeyEvent(IKeyboard keyboard, Key keycode, int scancode, bool down)
    {
        ImGuiIOPtr io = ImGui.GetIO();
        ImGuiKey imGuiKey = TranslateInputKeyToImGuiKey(keycode);
        io.AddKeyEvent(imGuiKey, down);
        io.SetKeyEventNativeData(imGuiKey, (int) keycode, scancode);
    }

    private void OnKeyChar(IKeyboard arg1, char arg2)
    {
        _pressedChars.Add(arg2);
    }

    private void WindowResized(Vector2D<int> size)
    {
        _windowWidth = size.X;
        _windowHeight = size.Y;
    }

    /// <summary>
    /// Renders the ImGui draw list data.
    /// This method requires a <see cref="GraphicsDevice"/> because it may create new DeviceBuffers if the size of vertex
    /// or index data has increased beyond the capacity of the existing buffers.
    /// A <see cref="CommandList"/> is needed to submit drawing and resource update commands.
    /// </summary>
    public void Render()
    {
        if (_frameBegun)
        {
            IntPtr oldCtx = ImGui.GetCurrentContext();

            if (oldCtx != ImGuiContext)
            {
                ImGui.SetCurrentContext(ImGuiContext);
            }

            _frameBegun = false;
            ImGui.Render();
            instance.ImGui_ImplDX11_RenderDrawData(ImGui.GetDrawData());

            if (oldCtx != ImGuiContext)
            {
                ImGui.SetCurrentContext(oldCtx);
            }
        }
    }

    /// <summary>
    /// Updates ImGui input and IO configuration state.
    /// </summary>
    public void Update(float deltaSeconds)
    {
        IntPtr oldCtx = ImGui.GetCurrentContext();

        if (oldCtx != ImGuiContext)
        {
            ImGui.SetCurrentContext(ImGuiContext);
        }

        if (_frameBegun)
        {
            ImGui.Render();
        }

        SetPerFrameImGuiData(deltaSeconds);
        UpdateImGuiInput();

        _frameBegun = true;
        ImGui.NewFrame();

        if (oldCtx != ImGuiContext)
        {
            ImGui.SetCurrentContext(oldCtx);
        }
    }

    /// <summary>
    /// Sets per-frame data based on the associated window.
    /// This is called by Update(float).
    /// </summary>
    private void SetPerFrameImGuiData(float deltaSeconds)
    {
        var io = ImGuiNET.ImGui.GetIO();
        io.DisplaySize = new Vector2(_windowWidth, _windowHeight);

        if (_windowWidth > 0 && _windowHeight > 0)
        {
            io.DisplayFramebufferScale = new Vector2(
                _view.FramebufferSize.X / (float)_windowWidth,
                _view.FramebufferSize.Y / (float)_windowHeight);
        }

        io.DeltaTime = deltaSeconds; // DeltaTime is in seconds.
    }

    private void UpdateImGuiInput()
    {
        ImGuiIOPtr io = ImGui.GetIO();

        // TODO: Add support for multiple mice and keyboards
        IMouse mouse = _input.Mice[0];

        io.MouseDown[0] = mouse.IsButtonPressed(MouseButton.Left);
        io.MouseDown[1] = mouse.IsButtonPressed(MouseButton.Right);
        io.MouseDown[2] = mouse.IsButtonPressed(MouseButton.Middle);

        var point = new Point((int) mouse.Position.X, (int) mouse.Position.Y);
        io.MousePos = new Vector2(point.X, point.Y);

        ScrollWheel wheel = mouse.ScrollWheels[0];
        io.MouseWheel = wheel.Y;
        io.MouseWheelH = wheel.X;

        foreach (char c in _pressedChars)
        {
            io.AddInputCharacter(c);
        }

        _pressedChars.Clear();

        io.KeyCtrl = _keyboard.IsKeyPressed(Key.ControlLeft) || _keyboard.IsKeyPressed(Key.ControlRight);
        io.KeyAlt = _keyboard.IsKeyPressed(Key.AltLeft) || _keyboard.IsKeyPressed(Key.AltRight);
        io.KeyShift = _keyboard.IsKeyPressed(Key.ShiftLeft) || _keyboard.IsKeyPressed(Key.ShiftRight);
        io.KeySuper = _keyboard.IsKeyPressed(Key.SuperLeft) || _keyboard.IsKeyPressed(Key.SuperRight);
    }

    internal void PressChar(char keyChar)
    {
        _pressedChars.Add(keyChar);
    }

    /// <summary>
    /// Translates a Silk.NET.Input.Key to an ImGuiKey.
    /// </summary>
    /// <param name="key">The Silk.NET.Input.Key to translate.</param>
    /// <returns>The corresponding ImGuiKey.</returns>
    /// <exception cref="NotImplementedException">When the key has not been implemented yet.</exception>
    private static ImGuiKey TranslateInputKeyToImGuiKey(Key key)
    {
        return key switch
        {
            Key.Tab => ImGuiKey.Tab,
            Key.Left => ImGuiKey.LeftArrow,
            Key.Right => ImGuiKey.RightArrow,
            Key.Up => ImGuiKey.UpArrow,
            Key.Down => ImGuiKey.DownArrow,
            Key.PageUp => ImGuiKey.PageUp,
            Key.PageDown => ImGuiKey.PageDown,
            Key.Home => ImGuiKey.Home,
            Key.End => ImGuiKey.End,
            Key.Insert => ImGuiKey.Insert,
            Key.Delete => ImGuiKey.Delete,
            Key.Backspace => ImGuiKey.Backspace,
            Key.Space => ImGuiKey.Space,
            Key.Enter => ImGuiKey.Enter,
            Key.Escape => ImGuiKey.Escape,
            Key.Apostrophe => ImGuiKey.Apostrophe,
            Key.Comma => ImGuiKey.Comma,
            Key.Minus => ImGuiKey.Minus,
            Key.Period => ImGuiKey.Period,
            Key.Slash => ImGuiKey.Slash,
            Key.Semicolon => ImGuiKey.Semicolon,
            Key.Equal => ImGuiKey.Equal,
            Key.LeftBracket => ImGuiKey.LeftBracket,
            Key.BackSlash => ImGuiKey.Backslash,
            Key.RightBracket => ImGuiKey.RightBracket,
            Key.GraveAccent => ImGuiKey.GraveAccent,
            Key.CapsLock => ImGuiKey.CapsLock,
            Key.ScrollLock => ImGuiKey.ScrollLock,
            Key.NumLock => ImGuiKey.NumLock,
            Key.PrintScreen => ImGuiKey.PrintScreen,
            Key.Pause => ImGuiKey.Pause,
            Key.Keypad0 => ImGuiKey.Keypad0,
            Key.Keypad1 => ImGuiKey.Keypad1,
            Key.Keypad2 => ImGuiKey.Keypad2,
            Key.Keypad3 => ImGuiKey.Keypad3,
            Key.Keypad4 => ImGuiKey.Keypad4,
            Key.Keypad5 => ImGuiKey.Keypad5,
            Key.Keypad6 => ImGuiKey.Keypad6,
            Key.Keypad7 => ImGuiKey.Keypad7,
            Key.Keypad8 => ImGuiKey.Keypad8,
            Key.Keypad9 => ImGuiKey.Keypad9,
            Key.KeypadDecimal => ImGuiKey.KeypadDecimal,
            Key.KeypadDivide => ImGuiKey.KeypadDivide,
            Key.KeypadMultiply => ImGuiKey.KeypadMultiply,
            Key.KeypadSubtract => ImGuiKey.KeypadSubtract,
            Key.KeypadAdd => ImGuiKey.KeypadAdd,
            Key.KeypadEnter => ImGuiKey.KeypadEnter,
            Key.KeypadEqual => ImGuiKey.KeypadEqual,
            Key.ShiftLeft => ImGuiKey.LeftShift,
            Key.ControlLeft => ImGuiKey.LeftCtrl,
            Key.AltLeft => ImGuiKey.LeftAlt,
            Key.SuperLeft => ImGuiKey.LeftSuper,
            Key.ShiftRight => ImGuiKey.RightShift,
            Key.ControlRight => ImGuiKey.RightCtrl,
            Key.AltRight => ImGuiKey.RightAlt,
            Key.SuperRight => ImGuiKey.RightSuper,
            Key.Menu => ImGuiKey.Menu,
            Key.Number0 => ImGuiKey._0,
            Key.Number1 => ImGuiKey._1,
            Key.Number2 => ImGuiKey._2,
            Key.Number3 => ImGuiKey._3,
            Key.Number4 => ImGuiKey._4,
            Key.Number5 => ImGuiKey._5,
            Key.Number6 => ImGuiKey._6,
            Key.Number7 => ImGuiKey._7,
            Key.Number8 => ImGuiKey._8,
            Key.Number9 => ImGuiKey._9,
            Key.A => ImGuiKey.A,
            Key.B => ImGuiKey.B,
            Key.C => ImGuiKey.C,
            Key.D => ImGuiKey.D,
            Key.E => ImGuiKey.E,
            Key.F => ImGuiKey.F,
            Key.G => ImGuiKey.G,
            Key.H => ImGuiKey.H,
            Key.I => ImGuiKey.I,
            Key.J => ImGuiKey.J,
            Key.K => ImGuiKey.K,
            Key.L => ImGuiKey.L,
            Key.M => ImGuiKey.M,
            Key.N => ImGuiKey.N,
            Key.O => ImGuiKey.O,
            Key.P => ImGuiKey.P,
            Key.Q => ImGuiKey.Q,
            Key.R => ImGuiKey.R,
            Key.S => ImGuiKey.S,
            Key.T => ImGuiKey.T,
            Key.U => ImGuiKey.U,
            Key.V => ImGuiKey.V,
            Key.W => ImGuiKey.W,
            Key.X => ImGuiKey.X,
            Key.Y => ImGuiKey.Y,
            Key.Z => ImGuiKey.Z,
            Key.F1 => ImGuiKey.F1,
            Key.F2 => ImGuiKey.F2,
            Key.F3 => ImGuiKey.F3,
            Key.F4 => ImGuiKey.F4,
            Key.F5 => ImGuiKey.F5,
            Key.F6 => ImGuiKey.F6,
            Key.F7 => ImGuiKey.F7,
            Key.F8 => ImGuiKey.F8,
            Key.F9 => ImGuiKey.F9,
            Key.F10 => ImGuiKey.F10,
            Key.F11 => ImGuiKey.F11,
            Key.F12 => ImGuiKey.F12,
            Key.F13 => ImGuiKey.F13,
            Key.F14 => ImGuiKey.F14,
            Key.F15 => ImGuiKey.F15,
            Key.F16 => ImGuiKey.F16,
            Key.F17 => ImGuiKey.F17,
            Key.F18 => ImGuiKey.F18,
            Key.F19 => ImGuiKey.F19,
            Key.F20 => ImGuiKey.F20,
            Key.F21 => ImGuiKey.F21,
            Key.F22 => ImGuiKey.F22,
            Key.F23 => ImGuiKey.F23,
            Key.F24 => ImGuiKey.F24,
            _ => throw new NotImplementedException(),
        };
    }

    /// <summary>
    /// Frees all graphics resources used by the renderer.
    /// </summary>
    public void Dispose()
    {
        _view.Resize -= WindowResized;
        _keyboard.KeyChar -= OnKeyChar;

        instance.ImGui_ImplDX11_Shutdown();

        ImGui.DestroyContext(ImGuiContext);
    }
}
