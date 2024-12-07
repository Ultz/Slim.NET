// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

#pragma warning disable CS9113 // Parameter is unread.
internal partial class SdlSurfaceComponents(SdlSurface surface)
#pragma warning restore CS9113 // Parameter is unread.
{
    public static bool IsChildrenEnabled { get; private set; }
    public static bool IsDisplayEnabled => true;
    public static bool IsOpenGLEnabled { get; private set; }
    public static bool IsScaleEnabled => true;
    public static bool IsVulkanEnabled { get; private set; }
    public static bool IsWindowEnabled { get; private set; }

    /// <summary>
    /// The window handle. Before creation this is either <c>nullptr</c> or a temporary window handle.
    /// </summary>
    public WindowHandle Handle { get; private set; }

    /// <summary>
    /// The window ID. Only valid if <see cref="Handle"/> is valid and <see cref="IsSurfaceInitialized"/> is
    /// <c>true</c>.
    /// </summary>
    public uint Id { get; private set; }

    public bool IsSurfaceInitialized { get; set; }

    private static uint _platformInitCount;

    private void AssertUninit()
    {
        if (IsSurfaceInitialized)
        {
            throw new InvalidOperationException(
                "This property can only be set during surface initialization (i.e. "
                    + "within the ISurfaceApplication.Initialize<T>() method)."
            );
        }
    }

    /// <summary>
    /// Initializes the platform and returns the temporary window handle used in the process if applicable.
    /// </summary>
    /// <returns>
    /// The window handle. May be <c>nullptr</c>, in which case the platform was already initialised.
    /// </returns>
    public static WindowHandle InitializePlatform()
    {
        DebugPrint($"reached, ref count before {_platformInitCount}");
        if (Interlocked.Increment(ref _platformInitCount) > 1)
        {
            return nullptr;
        }

        if (!Sdl.InitSubSystem(Sdl.InitVideo))
        {
            Sdl.ThrowError();
            return nullptr;
        }

        IsOpenGLEnabled = Sdl.GLLoadLibrary(nullptr);
        DebugPrintWithError(IsOpenGLEnabled ? "OpenGL support enabled" : "OpenGL support disabled");

        IsVulkanEnabled = Sdl.VulkanLoadLibrary(nullptr);
        DebugPrintWithError(IsVulkanEnabled ? "Vulkan support enabled" : "Vulkan support disabled");
        Sdl.ClearError();

        var props = CreateDummyWindowProps();
        var tempWindow = Sdl.CreateWindowWithProperties(props);
        if (tempWindow == nullptr)
        {
            // Should be able to at least create a window.
            Sdl.DestroyProperties(props);
            Sdl.ThrowError();
            return nullptr;
        }

        var tempChildWindow = Sdl.CreateWindowWithProperties(props);
        if (tempChildWindow != nullptr)
        {
            IsChildrenEnabled = true;
            Sdl.DestroyWindow(tempChildWindow);
        }

        DebugPrintWithError(IsChildrenEnabled ? "Children supported" : "Children unsupported");
        Sdl.ClearError();

        IsWindowEnabled = Sdl.SetWindowPosition(tempWindow, 1, 1);
        DebugPrintWithError($"Window decoration {(IsWindowEnabled ? "supported" : "unsupported")}");
        Sdl.ClearError();
        Sdl.DestroyProperties(props);
        return tempWindow;
    }

    private static uint CreateDummyWindowProps()
    {
        var props = Sdl.CreateProperties();
        Sdl.SetBooleanProperty(props, Sdl.PropWindowCreateHiddenBoolean, true);
        return props;
    }

    public void PreInitializeSurface()
    {
        DebugPrint();
        Handle = InitializePlatform();
    }

    public void InitializeSurface()
    {
        var createProps = Sdl.CreateProperties();
        try
        {
            if (IsDisplayEnabled)
            {
                InitializeDisplay(createProps);
            }

            if (IsOpenGLEnabled)
            {
                InitializeOpenGL(createProps);
            }

            if (IsVulkanEnabled)
            {
                InitializeVulkan(createProps);
            }

            if (IsWindowEnabled)
            {
                InitializeWindow(createProps);
            }

            if (Handle != nullptr)
            {
                Sdl.DestroyWindow(Handle);
            }

            DebugPrintAllProps(createProps);
            Handle = Sdl.CreateWindowWithProperties(createProps);
        }
        finally
        {
            Sdl.DestroyProperties(createProps);
        }

        if (Handle == nullptr)
        {
            Sdl.ThrowError();
        }

        Id = Sdl.GetWindowID(Handle);
        SdlEventProcessor.AddSurface(Id, surface);
        DebugPrintAllProps(Sdl.GetWindowProperties(Handle));
        IsSurfaceInitialized = true;
        if (IsOpenGLEnabled)
        {
            PostInitializeOpenGL();
        }

        DebugPrint("Initialized");
    }

    public static void TerminatePlatform()
    {
        DebugPrint($"reached, ref count is {_platformInitCount}");
        if (Interlocked.Decrement(ref _platformInitCount) != 0)
        {
            return;
        }

        Sdl.QuitSubSystem(Sdl.InitVideo);
        if (IsOpenGLEnabled)
        {
            Sdl.GLUnloadLibrary();
        }

        if (IsVulkanEnabled)
        {
            Sdl.VulkanUnloadLibrary();
        }
    }

    public void Dispose()
    {
        if (Handle != nullptr)
        {
            SdlEventProcessor.RemoveSurface(Id);
            Sdl.DestroyWindow(Handle);
        }

        TerminatePlatform();
    }
}
