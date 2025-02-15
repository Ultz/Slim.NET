// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.Maths;

namespace Silk.NET.Input;

/// <summary>
/// Contains extensions for creating input backends and contexts from <see cref="INativeWindow"/>s.
/// </summary>
public static partial class InputWindowExtensions
{
    /// <summary>
    /// Creates an instance of the "reference implementation" of <see cref="IInputBackend"/> for the given
    /// <see cref="INativeWindow"/>, provided that this was also sourced from the "reference implementation" of the
    /// windowing API.
    /// </summary>
    /// <remarks>
    /// Regarding the threading rules documented on <see cref="IInputBackend"/>, <see cref="IInputBackend.Update"/>
    /// must only be called on the "main thread," i.e. the same thread that windowing operates on.
    /// </remarks>
    /// <param name="window">The window to create an input backend from.</param>
    /// <returns>The input backend.</returns>
    /// <exception cref="NotSupportedException">
    /// If the given <see cref="INativeWindow"/> is not compatible with the reference implementation for this platform.
    /// </exception>
    public static partial IInputBackend CreateInputBackend(this INativeWindow window);

    /// <summary>
    /// Creates an <see cref="InputContext"/> that uses the "reference implementation" of <see cref="IInputBackend"/>
    /// for the given <see cref="INativeWindow"/> as its only backend, provided that the <see cref="INativeWindow"/> was
    /// also sourced from the "reference implementation" of the windowing API.
    /// </summary>
    /// <remarks>
    /// Regarding the threading rules documented on <see cref="InputContext"/>, <see cref="InputContext.Update"/>
    /// must only be called on the "main thread," i.e. the same thread that windowing operates on.
    /// </remarks>
    /// <param name="window">The window to create an input backend from.</param>
    /// <returns>
    /// The <see cref="InputContext"/> created with the instantiated input backend as its only backend.
    /// </returns>
    /// <exception cref="NotSupportedException">
    /// If the given <see cref="INativeWindow"/> is not compatible with the reference implementation for this platform.
    /// </exception>
    public static InputContext CreateInput(this INativeWindow window)
    {
        var ret = new InputContext();
        ret.Backends.Add(window.CreateInputBackend());
        return ret;
    }
}

/// <summary>
/// Represents a connected Human Input Device (HID).
/// </summary>
/// <remarks>
/// All devices originate from a backend.<br />
/// <br />
/// An <see cref="IInputDevice"/> object shall be equatable to any such object retrieved from the same backend where
/// <see cref="Id"/> is equal.<br />
/// <br />
/// <see cref="IInputDevice"/> objects must not store any managed state, and if there is a requirement for this in a
/// future extension of this API then this must be defined in such a way that the state storage and lifetime is
/// user-controlled. While <see cref="IInputDevice"/> objects are equatable based on <see cref="Id"/>s, if a physical
/// device disconnects and reconnects the <see cref="IInputBackend"/> does not provide a guarantee that the same object
/// will be returned (primarily because doing so would require the <see cref="IInputBackend"/> to keep track of every
/// object it's ever created), rather a "compatible" one that acts identically to the original object. This is
/// completely benign if the object is nothing but a wrapper to the backend anyway. If there is unmanaged state (e.g. a
/// handle to a device that must be explicitly closed upon disconnection), then it is expected that even in the event of
/// reconnection, old objects (e.g. created with a now-disposed handle) shall still work for the newly-reconnected
/// device. A common way this could be implemented is storing the handles in the <see cref="IInputBackend"/>
/// implementation instead in the form of a mapping of physical device IDs (<see cref="Id"/>) to those handles. This
/// solves the object lifetime problem while also not adding undue complications to user code.
/// </remarks>
public interface IInputDevice : IEquatable<IInputDevice>
{
    /// <summary>
    /// Gets a globally-unique integral identifier for this device.
    /// </summary>
    nint Id { get; }

    /// <summary>
    /// Gets a rough human-readable description of the input device. Its value is not intrinsically meaningful.
    /// </summary>
    string Name { get; }
}

/// <summary>
/// Represents an input backend capable of receiving human input from Human Input Devices (HIDs).
/// </summary>
/// <remarks>
/// The onus is on the user to coordinate using this type across threads, as the input backend is not thread safe
/// In addition, certain backends may have (unavoidable) restrictions on what thread <see cref="Update"/> can be called
/// on - the user is responsible for respecting these threading rules as well.
/// </remarks>
public interface IInputBackend
{
    /// <summary>
    /// Gets a rough human-readable description of the input backend. Its value is not intrinsically meaningful.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets a globally-unique integral identifier for this device.
    /// </summary>
    nint Id { get; }

    /// <summary>
    /// Get a list containing all the <b>connected</b> devices available from this input backend.
    /// </summary>
    /// <remarks>
    /// When a device is disconnected, its <see cref="IInputDevice"/> shall no longer function and will not be
    /// enumerated by this list. When a device is connected, an <see cref="IInputDevice"/> with that physical device ID
    /// shall be added to this list. In addition, upon connection any past <see cref="IInputDevice"/> objects previously
    /// enumerated by this list on this <see cref="IInputBackend"/> instance shall also regain function if the device
    /// being added to this list shares the same physical device ID as those previous instances. All such previous
    /// instances shall be equatable to one another and to the <see cref="IInputDevice"/> instance added to this list.
    /// An implementation is welcome to reuse old objects, but this is strictly implementation-defined. A device not
    /// being present in the <see cref="Devices"/> (checked using <see cref="IInputDevice"/>s
    /// <see cref="IEquatable{IInputDevice}"/> implementation) list is sufficient evidence that a device has been
    /// disconnected.
    /// </remarks>
    IReadOnlyList<IInputDevice> Devices { get; }

    /// <summary>
    /// Polls and updates the state of the <see cref="IInputDevice"/> objects connected using this backend, sending
    /// input events to the given <see cref="IInputHandler"/> to reflect the human input received.
    /// </summary>
    /// <remarks>
    /// The value of the <c>State</c> properties on each device must not change until this method is called.
    /// </remarks>
    /// <param name="handler">The input handler.</param>
    void Update(IInputHandler? handler = null);
}

/// <summary>
/// Represents a handler of human input. Implementations of this type will receive a method call for each distinctive
/// HID event received in the order they were received, to the best of the backend's ability. All visible changes to
/// device state correspond to a method call using this interface.
/// </summary>
public interface IInputHandler
{
    /// <summary>
    /// Called when an <see cref="IInputDevice"/> disconnects from the application.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleDeviceConnectionChanged(ConnectionEvent @event);
}

/// <summary>
/// Represents an "input context" containing multiple <see cref="IInputBackend"/>s from which
/// <see cref="IInputDevice"/>s, their state, and their events are aggregated and laid-out in a user-friendly fashion.
/// </summary>
/// <remarks>
/// The onus is on the user to coordinate using this type across threads, as the input backend is not thread safe
/// In addition, certain backends may have (unavoidable) restrictions on what thread <see cref="Update"/> can be called
/// on - the user is responsible for respecting these threading rules as well.
/// </remarks>
public partial class InputContext
{
    /// <summary>
    /// Gets the <see cref="IPointerDevice"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Pointers Pointers { get; }

    /// <summary>
    /// Gets the <see cref="IKeyboard"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Keyboards Keyboards { get; }

    /// <summary>
    /// Gets the <see cref="IGamepad"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Gamepads Gamepads { get; }

    /// <summary>
    /// Gets the <see cref="IJoystick"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Joysticks Joysticks { get; }

    /// <summary>
    /// Gets the <see cref="IInputDevice"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public IReadOnlyList<IInputDevice> Devices { get; }

    /// <summary>
    /// Gets a list denoting the <see cref="IInputBackend"/> attached to this context.
    /// </summary>
    public IList<IInputBackend> Backends { get; }

    /// <summary>
    /// Raised when a device is added or removed from the list of connected <see cref="Devices"/>.
    /// </summary>
    public event Action<ConnectionEvent>? ConnectionChanged;

    /// <summary>
    /// Polls and updates the state of the <see cref="IInputDevice"/> objects connected to each
    /// <see cref="IInputBackend"/> attached to this context, raising appropriate events for each state change.
    /// </summary>
    /// <remarks>
    /// This calls <see cref="IInputBackend.Update"/> for each <see cref="IInputBackend"/> attached to this context.
    /// </remarks>
    public void Update();
}

/// <summary>
/// Represents a collection of <see cref="IPointerDevice"/>s from which input events can be received.
/// </summary>
public partial class Pointers : IReadOnlyList<IPointerDevice>
{
    /// <summary>
    /// Gets or sets the configuration that denotes the behaviour of <see cref="Click"/>/<see cref="DoubleClick"/>.
    /// </summary>
    public PointerClickConfiguration ClickConfiguration { get; set; }

    /// <summary>
    /// Raised when state pertaining to a pushable button on the pointer device changes (e.g. button up, button down).
    /// </summary>
    public event Action<ButtonChangedEvent<PointerButton>>? ButtonChanged;

    /// <summary>
    /// Raised when one or more <see cref="ButtonChanged"/> events indicate a single click as defined by the
    /// <see cref="ClickConfiguration"/>.
    /// </summary>
    public event Action<PointerClickEvent>? Click;

    /// <summary>
    /// Raised when one or more <see cref="ButtonChanged"/> events indicate a double click as defined by the
    /// <see cref="ClickConfiguration"/>.
    /// </summary>
    public event Action<PointerClickEvent>? DoubleClick;

    /// <summary>
    /// Raised when a <see cref="TargetPoint"/>'s state changes (e.g. mouse move).
    /// </summary>
    public event Action<PointChangedEvent>? PointChanged;

    /// <summary>
    /// Raised when a user scrolls using a pointer device's mouse wheel.
    /// </summary>
    public event Action<MouseScrollEvent>? MouseScroll;
}

/// <summary>
/// Represents a collection of <see cref="IKeyboard"/>s from which input events can be received.
/// </summary>
public partial class Keyboards : IReadOnlyList<IKeyboard>
{
    /// <summary>
    /// Raised when state pertaining to a pushable key on the keyboard changes (e.g. key up, key down, key repeat).
    /// </summary>
    public event Action<KeyChangedEvent>? KeyChanged;

    /// <summary>
    /// Raised when the user types a character using the keyboard.
    /// </summary>
    public event Action<KeyCharEvent>? KeyChar;
}

/// <summary>
/// Represents a collection of <see cref="IGamepad"/>s from which input events can be received.
/// </summary>
public partial class Gamepads : IReadOnlyList<IGamepad>
{
    /// <summary>
    /// Raised when state pertaining to a pushable button on the gamepad changes (e.g. button up, button down).
    /// </summary>
    public event Action<ButtonChangedEvent<JoystickButton>>? ButtonChanged;

    /// <summary>
    /// Raised when a thumbstick on the gamepad moves.
    /// </summary>
    public event Action<GamepadThumbstickMoveEvent>? ThumbstickMove;

    /// <summary>
    /// Raised when a trigger on the gamepad moves.
    /// </summary>
    public event Action<GamepadTriggerMoveEvent>? TriggerMove;
}

/// <summary>
/// Represents a collection of <see cref="IJoystick"/>s from which input events can be received.
/// </summary>
public partial class Joysticks : IReadOnlyList<IJoystick>
{
    /// <summary>
    /// Raised when state pertaining to a pushable button on the joystick changes (e.g. button up, button down).
    /// </summary>
    public event Action<ButtonChangedEvent<JoystickButton>>? ButtonChanged;

    /// <summary>
    /// Raised when a movable axis on the joystick changes position.
    /// </summary>
    public event Action<JoystickAxisMoveEvent>? AxisMove;

    /// <summary>
    /// Raised when a joystick hat moves.
    /// </summary>
    public event Action<JoystickHatMoveEvent>? HatMove;
}

/// <summary>
/// Denotes the configuration for recognising <see cref="Pointers.DoubleClick"/> events apart from single
/// <see cref="Pointers.Click"/> events.
/// </summary>
/// <param name="DoubleClickTime">
/// The maximum time in milliseconds between two consecutive clicks to count as a double click.
/// </param>
/// <param name="DoubleClickRange">
/// The maximum distance in pixels between two consecutive clicks to count as a double click.
/// </param>
public record struct PointerClickConfiguration(int DoubleClickTime, float DoubleClickRange);

/// <summary>
/// Contains information pertaining to a device connection or disconnection event.
/// </summary>
/// <param name="Device">The device that has disconnected or connected.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="IsConnected">Whether the device has connected (<c>true</c>) or disconnected (<c>false</c>).</param>
public readonly record struct ConnectionEvent(IInputDevice Device, long Timestamp, bool IsConnected);

/// <summary>
/// Contains information pertaining to a key press state change.
/// </summary>
/// <param name="Keyboard">The keyboard on which the key being pressed or depressed resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Key">The new state of the key being pressed or depressed.</param>
/// <param name="Previous">The previous state of the key.</param>
/// <param name="IsRepeat">Whether this is an event that has been repeated at an implementation-defined rate.</param>
/// <param name="Modifiers">The active key modifiers at the time the event was raised.</param>
public readonly record struct KeyChangedEvent(IKeyboard Keyboard, long Timestamp, Button<KeyName> Key, Button<KeyName> Previous, bool IsRepeat, KeyModifiers Modifiers);

/// <summary>
/// Contains information pertaining to a character being typed on a keyboard.
/// </summary>
/// <param name="Keyboard">The keyboard with which the end user typed a character.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Character">The character that was typed. A <c>null</c> character denotes a backspace.</param>
public readonly record struct KeyCharEvent(IKeyboard Keyboard, long Timestamp, char? Character);

/// <summary>
/// Contains information pertaining to a button state change (e.g. press, depress, etc).
/// </summary>
/// <param name="Device">The device on which the button being pressed or depressed resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Button">The new state of the button being pressed or depressed.</param>
/// <param name="Previous">The previous state of the button.</param>
/// <typeparam name="T">The button type e.g. <see cref="JoystickButton"/>, <see cref="PointerButton"/>, etc.</typeparam>
public readonly record struct ButtonChangedEvent<T>(IButtonDevice<T> Device, long Timestamp, Button<T> Button, Button<T> Previous) where T : struct, Enum;

/// <summary>
/// Contains information pertaining to a <see cref="TargetPoint"/> change on a <see cref="IPointerDevice"/>,
/// </summary>
/// <param name="Pointer">The pointer device with which the user is pointing.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="OldPoint">
/// The previous state for this <see cref="TargetPoint"/>. If this is a new point (e.g. a finger has only just touched a
/// touch screen), this shall be <c>null</c>.
/// </param>
/// <param name="NewPoint">
/// The new state for this <see cref="TargetPoint"/>. If the point is no longer valid (e.g. a finger is no longer
/// touching a touch screen), this shall be <c>null</c>.
/// </param>
public readonly record struct PointChangedEvent(IPointerDevice Pointer, long Timestamp, TargetPoint? OldPoint, TargetPoint? NewPoint);

/// <summary>
/// Contains information pertaining to the user changing the pressure with which they're applying their grip on the
/// given pointer device.
/// </summary>
/// <param name="Pointer">The pointer device the user is gripping.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="GripPressure">
/// The grip pressure being applied to the device, where <c>0.0</c> is the lowest amount of pressure measurable by the
/// device and <c>1.0</c> is the maximum amount of pressure measurable by the device.
/// </param>
/// <param name="Delta">The change in <see cref="GripPressure"/> from its previous value.</param>
public readonly record struct PointerGripChangedEvent(IPointerDevice Pointer, long Timestamp, float GripPressure, float Delta);

/// <summary>
/// Contains information pertaining to changes to a "target" at which the user can point using a pointer device.
/// </summary>
/// <param name="Pointer">The pointer with which the user can point at the given target.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Target">The target at which the user can point.</param>
/// <param name="IsAdded">
/// <c>true</c> if this is a newly-added target to <see cref="IPointerDevice.Targets"/>,
/// <c>false</c> if this target has been removed from the list of available <see cref="IPointerDevice.Targets"/>,
/// <c>null</c> if there has been no change to the target's validity.
/// </param>
/// <param name="OldBounds">
/// The old <see cref="IPointerTarget.Bounds"/> of the target. This may be the same as <see cref="NewBounds"/> if there
/// has been no change.
/// </param>
/// <param name="NewBounds">
/// The new <see cref="IPointerTarget.Bounds"/> of the target. This may be the same as <see cref="OldBounds"/> if there
/// has been no change.
/// </param>
public readonly record struct PointerTargetChangedEvent(IPointerDevice Pointer, long Timestamp, IPointerTarget Target, bool? IsAdded, Box3D<float> OldBounds, Box3D<float> NewBounds);

/// <summary>
/// Contains information pertaining to the user scrolling using a mouse scroll wheel.
/// </summary>
/// <param name="Mouse">The mouse on which the scroll wheel resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Point">The mouse's active point when the scroll event occurred.</param>
/// <param name="WheelPosition">The <see cref="MouseState.WheelPosition"/> after the event occurred.</param>
/// <param name="Delta">
/// The change in <see cref="WheelPosition"/> as a result of this event represented as a number of ratchets.
/// </param>
public readonly record struct MouseScrollEvent(IMouse Mouse, long Timestamp, TargetPoint Point, Vector2 WheelPosition, Vector2 Delta);

/// <summary>
/// Contains information pertaining to a pointer button being pressed and released (i.e. clicked).
/// </summary>
/// <param name="Pointer">The pointer device on which the button being pressed and released resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Point">
/// A specific <see cref="TargetPoint"/> for which the button press occurred, check <see cref="TargetPoint.IsValid"/> to
/// validate if such a point was available.
/// </param>
/// <param name="Button">The button that was pressed and released in succession.</param>
public readonly record struct PointerClickEvent(IPointerDevice Pointer, long Timestamp, TargetPoint Point, PointerButton Button);

/// <summary>
/// Contains information pertaining to the movement of a joystick hat.
/// </summary>
/// <param name="Joystick">The joystick on which the hat being moved resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Value">The position of the hat after this event.</param>
/// <param name="Delta">The change in <see cref="Value"/> as a result of this event.</param>
public readonly record struct JoystickHatMoveEvent(IJoystick Joystick, long Timestamp, Vector2 Value, Vector2 Delta);

/// <summary>
/// Contains information pertaining to the movement of a joystick axis.
/// </summary>
/// <param name="Joystick">The joystick on which the axis being moved resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Axis">The index of the axis being moved.</param>
/// <param name="Value">The new value of the axis, typically between <c>0.0</c> and <c>1.0</c>.</param>
/// <param name="Delta">The change in <see cref="Value"/> as a result of this event.</param>
public readonly record struct JoystickAxisMoveEvent(IJoystick Joystick, long Timestamp, int Axis, float Value, float Delta);

/// <summary>
/// Contains information pertaining to the movement of a thumbstick.
/// </summary>
/// <param name="Gamepad">The gamepad on which the thumbstick resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Value">
/// The new position of the thumbstick, where each axis is between <c>-1.0</c> and <c>1.0</c>.
/// </param>
/// <param name="Delta">The change in <see cref="Value"/> as a result of this event.</param>
public readonly record struct GamepadThumbstickMoveEvent(IGamepad Gamepad, long Timestamp, Vector2 Value, Vector2 Delta);

/// <summary>
/// Contains information pertaining to the movement of a trigger.
/// </summary>
/// <param name="Gamepad">The gamepad on which the trigger resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Axis">The index of the trigger that has moved.</param>
/// <param name="Value">
/// The new value of the trigger, between <c>0.0</c> (fully depressed) and <c>1.0</c> (fully pressed).
/// </param>
/// <param name="Delta">The change in <see cref="Value"/> as a result of this event.</param>
public readonly record struct GamepadTriggerMoveEvent(IGamepad Gamepad, long Timestamp, int Axis, float Value, float Delta);

/// <summary>
/// An opaque implementation of <see cref="IReadOnlyList{T}"/> that is optimised for storing a <c>Silk.NET.Input</c>
/// type specified by <typeparamref name="T"/> using the most memory-efficient mechanism available.
/// </summary>
/// <typeparam name="T">The <c>Silk.NET.Input</c> type to store.</typeparam>
public struct InputReadOnlyList<T> : IReadOnlyList<T>
{
    /// <summary>
    /// Creates an <see cref="InputReadOnlyList{T}"/> from a <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <param name="other">The list to copy.</param>
    public InputReadOnlyList(IReadOnlyList<T> other);
}

/// <summary>
/// An implementation of <see cref="IReadOnlyList{T}"/> providing utility APIs for getting a <see cref="Button{T}"/>
/// given a button name <typeparamref name="T"/>, that is optimised for storing <see cref="Button{T}"/>s with the
/// given button name type <typeparamref name="T"/> using the most memory-efficient mechanism available.
/// </summary>
/// <typeparam name="T">
/// The button type (e.g. <see cref="JoystickButton"/>, <see cref="PointerButton"/>, etc).
/// </typeparam>
public struct ButtonReadOnlyList<T> : IReadOnlyList<Button<T>> where T : struct, Enum
{
    /// <summary>
    /// Creates an <see cref="ButtonReadOnlyList{T}"/> from a <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <param name="other">The list to copy.</param>
    public ButtonReadOnlyList(IReadOnlyList<Button<T>> other);

    /// <summary>
    /// Gets the state for the button with the given name.
    /// </summary>
    /// <param name="name">The button name.</param>
    public Button<T> this[T name] { get; }
}

/// <summary>
/// Represents a button the user can push.
/// </summary>
/// <param name="Name">The name of the button.</param>
/// <param name="IsDown">Whether the user is pushing the button.</param>
/// <param name="Pressure">
/// The pressure with which the user is pushing the button, where <c>0.0</c> is the smallest measurable pressure and
/// <c>1.0</c> is the largest measurable pressure.
/// </param>
/// <typeparam name="T">
/// The button type (e.g. <see cref="JoystickButton"/>, <see cref="PointerButton"/>, etc).
/// </typeparam>
public readonly record struct Button<T>(T Name, bool IsDown, float Pressure) where T : struct, Enum
{
    /// <summary>
    /// Collapses this <see cref="Button{T}"/> struct into just its <see cref="IsDown"/> value.
    /// </summary>
    /// <param name="state">The button state.</param>
    /// <returns>The <see cref="IsDown"/> value.</returns>
    public static implicit operator bool(Button<T> state) => state.IsDown;
}

/// <summary>
/// Represents an input device that has buttons.
/// </summary>
/// <typeparam name="T">The type of buttons the input device has.</typeparam>
public interface IButtonDevice<T> : IInputDevice where T: struct, Enum
{
    /// <summary>
    /// Gets the current button state for this device.
    /// </summary>
    /// <remarks>
    /// Only updated when <see cref="IInputBackend.Update"/> is called.
    /// </remarks>
    ButtonReadOnlyList<T> State { get; }
}

/// <summary>
/// An <see cref="IInputHandler"/> that also receives <see cref="IButtonDevice{T}"/> events.
/// </summary>
/// <typeparam name="T">The device's button type.</typeparam>
public interface IButtonInputHandler<T> where T : struct, Enum
{
    /// <summary>
    /// Called when a button's state changes (e.g. button down, button up).
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleButtonChanged(ButtonChangedEvent<T> @event);
}

/// <summary>
/// Represents a device with which the user can point at a target.
/// </summary>
public interface IPointerDevice : IButtonDevice<PointerButton>
{
    /// <summary>
    /// Gets the device state.
    /// </summary>
    /// <remarks>
    /// Only updated when <see cref="IInputBackend.Update"/> is called.
    /// </remarks>
    PointerState State { get; }
    ButtonReadOnlyList<PointerButton> IButtonDevice<PointerButton>.State => State.Buttons;
    /// <summary>
    /// Gets the targets at which the user can point with their pointer.
    /// </summary>
    IReadOnlyList<IPointerTarget> Targets { get; }
}

/// <summary>
/// Represents a target at which the user can point using their pointer device.
/// </summary>
public interface IPointerTarget
{
    /// <summary>
    /// The boundary in which positions of points on this target shall fall. For <see cref="Box3D{T}.Min" />,
    /// <see cref="float.NegativeInfinity" /> shall represent the lack of a lower bound on a particular axis. For
    /// For <see cref="Box3D{T}.Max" />, <see cref="float.PositiveInfinity" /> shall represent the lack of a lower bound
    /// on a particular axis. <c>0</c> represents an unused axis that axis is <c>0</c> on both
    /// <see cref="Box3D{T}.Min" /> and <see cref="Box3D{T}.Max" />.
    /// </summary>
    Box3D<float> Bounds { get; }

    /// <summary>
    /// Gets the number of points with which the given pointer is pointing at this target.
    /// </summary>
    /// <returns>The number of points.</returns>
    /// <remarks>
    /// A single "logical" pointer device may have many points, and can optionally represent multiple physical pointers
    /// as a single logical device - this is the case where a backend supports multiple mice to control an
    /// cursor on its "raw mouse input" target, but combines these all to a single point on its "windowed" target. This
    /// is also true for touch input - a touch screen is represented as a single touch device,
    /// where each finger is its own point.
    /// </remarks>
    int GetPointCount(IPointerDevice pointer);

    /// <summary>
    /// Gets a point with which the given pointer is pointing at this target.
    /// </summary>
    /// <param name="pointer">The pointer device.</param>
    /// <param name="point">
    /// The index of the point, between <c>0</c> and the number sourced from <see cref="GetPointCount" />.
    /// </param>
    /// <returns>The point at the given index with which the given pointer device is pointing at the target.</returns>
    TargetPoint GetPoint(IPointerDevice pointer, int point);
}
/// <summary>
/// Flags describing a <see cref="TargetPoint" /> state.
/// </summary>
[Flags]
public enum TargetPointFlags
{
    /// <summary>
    /// No flags are set, indicating that the point is not being pointed at and therefore may not be valid.
    /// </summary>
    NotPointingAtTarget = 0,

    /// <summary>
    /// Indicates that the point has been resolved as a valid point at which the pointer is pointing.
    /// </summary>
    PointingAtTarget = 1 << 0
}

/// <summary>
/// Represents a point on a target at which a pointer is pointing.
/// </summary>
/// <param name="Id">
/// An integral identifier for the point. This point must be the only point for the device currently pointing at a
/// target with this identifier at any given time. If this point ceases to point at the target, then the identifier
/// becomes free for another device point. This means that this identifier can just be an index, but may be globally
/// unique depending on the backend's capabilities.
/// </param>
/// <param name="Flags">Flags describing the state of the point.</param>
/// <param name="Position">The absolute position on the target at which the pointer is pointing.</param>
/// <param name="NormalizedPosition">
/// The normalized position on the target at which the pointer is pointing, if applicable. If this is not available
/// (e.g. due to the target being infinitely large a.k.a. "unbounded"), then this property shall have a value of
/// <c>default</c>.
/// </param>
/// <param name="Pointer">
/// A ray representing the distance and angle at which the pointer is pointing at the point on the target. A ray with an
/// orientation equivalent to an identity quaternion shall be interpreted as the point directly perpendicular to and
/// facing towards the target, with this being the default value should this information be unavailable. If distance
/// information is unavailable, this shall be equivalent to a <c>default</c> vector.
/// </param>
/// <param name="Pressure">
/// The pressure applied to the point on the target by the pointer, between <c>0.0</c> representing the minimum amount
/// of pressure and <c>1.0</c> representing the maximum amount of pressure. This shall be <c>1.0</c> if such data is
/// unavailable but the point is otherwise valid.
/// </param>
/// <param name="Target">The pointer being pointed at.</param>
public readonly record struct TargetPoint(
    int Id,
    TargetPointFlags Flags,
    Vector3 Position,
    Vector3 NormalizedPosition,
    Ray3D<float> Pointer,
    float Pressure,
    IPointerTarget? Target
) {
    /// <summary>
    /// Gets a value indicating whether this <see cref="TargetPoint"/> is a valid instance of a point on a
    /// <see cref="Target"/> that the user is pointing at using their pointer device.
    /// </summary>
    [MemberNotNullWhen(true, nameof(Target))]
    public bool IsValid => (Flags & TargetPointFlags.PointingAtTarget) != TargetPointFlags.NotPointingAtTarget;
}

/// <summary>
///
/// </summary>
public class PointerState
{
    public ButtonReadOnlyList<PointerButton> Buttons { get; }
    public InputReadOnlyList<TargetPoint> Points { get; }
    public float GripPressure { get; }
}
public interface IPointerInputHandler : IButtonInputHandler<PointerButton>
{
    void HandleTargetChanged(PointerTargetChangedEvent @event);
    void HandlePointChanged(PointChangedEvent @event);
    void HandleGripChanged(PointerGripChangedEvent @event);
}
public enum PointerButton
{
    Primary,
    Secondary,
    Button3,
    MiddleButton = Button3,
    Button4,
    Button5,
    Button6,
    Button7,
    Button8,
    Button9,
    Button10,
    Button11,
    Button12,
    Button13,
    Button14,
    Button15,
    Button16,
    Button17,
    Button18,
    Button19,
    Button20,
    Button21,
    Button22,
    Button23,
    Button24,
    Button25,
    Button26,
    Button27,
    Button28,
    Button29,
    Button30,
    EraserTip = Button30,
    Button31,
    Button32
}
public interface IMouse : IPointerDevice
{
    MouseState State { get; }
    PointerState IPointerDevice.State => State;
    ICursorConfiguration Cursor { get; }
    bool TrySetPosition(Vector2 position);
}
public class MouseState : PointerState
{
    public Vector2 WheelPosition { get; }
}
public interface IMouseInputHandler : IButtonInputHandler<PointerButton>
{
    void HandleScroll(MouseScrollEvent @event);
}
public readonly ref struct CustomCursor
{
    public int Width { get; init; }
    public int Height { get; init; }
    public ReadOnlySpan<int> Data { get; init; } // Rgba32
}

public interface ICursorConfiguration
{
    CursorModes SupportedModes { get; }
    CursorModes Mode { get; set; }
    CursorStyles SupportedStyles { get; }
    CursorStyles Style { get; set; }
    CustomCursor Image { get; set; }
}

[Flags]
public enum CursorModes
{
    Normal = 1 << 0,
    Confined = 1 << 1,
    Unbounded = 1 << 2,
}

    [Flags]
public enum CursorStyles
{
    Default,
    Arrow = 1 << 0,
    IBeam = 1 << 1,
    Crosshair = 1 << 2,
    Hand = 1 << 3,
    HResize = 1 << 4,
    VResize = 1 << 5,
    Hidden = 1 << 6,
    Custom = 1 << 7,
}
public interface IKeyboard : IButtonDevice<KeyName>
{
    KeyboardState State { get; }
    string? ClipboardText { get; set; }
    bool TryGetKeyName(KeyName key, [NotNullWhen(true)] out string? name);
    void BeginInput();
    void EndInput();
}
public class KeyboardState
{
    public InputReadOnlyList<char>? Text { get; }
    public ButtonReadOnlyList<KeyName> Keys { get; }
    public KeyModifiers Modifiers { get; }
}
public interface IKeyboardInputHandler : IButtonInputHandler<KeyName>
{
    void HandleKeyChanged(KeyChangedEvent @event);
    void HandleKeyChar(KeyCharEvent @event);
}
public enum KeyName
{
    // These values are from usage page 0x07 (USB keyboard page).
    Unknown = 0,
    A = 4,
    B = 5,
    C = 6,
    D = 7,
    E = 8,
    F = 9,
    G = 10,
    H = 11,
    I = 12,
    J = 13,
    K = 14,
    L = 15,
    M = 16,
    N = 17,
    O = 18,
    P = 19,
    Q = 20,
    R = 21,
    S = 22,
    T = 23,
    U = 24,
    V = 25,
    W = 26,
    X = 27,
    Y = 28,
    Z = 29,
    Number1 = 30,
    Number2 = 31,
    Number3 = 32,
    Number4 = 33,
    Number5 = 34,
    Number6 = 35,
    Number7 = 36,
    Number8 = 37,
    Number9 = 38,
    Number0 = 39,
    Return = 40,
    Escape = 41,
    Backspace = 42,
    Tab = 43,
    Space = 44,
    Minus = 45,
    Equals = 46,
    LeftBracket = 47,
    RightBracket = 48,
    Backslash = 49,
    NonUs1 = 50, // US: \| Belg: µ`£ FrCa: <}> Dan:’* Dutch: <> Fren:*µ Ger: #’ Ital: ù§ LatAm: }`] Nor:,* Span: }Ç Swed: , * Swiss: $£ UK: #~.
    Semicolon = 51,
    Apostrophe = 52,
    Grave = 53,
    Comma = 54,
    Period = 55,
    Slash = 56,
    CapsLock = 57,
    F1 = 58,
    F2 = 59,
    F3 = 60,
    F4 = 61,
    F5 = 62,
    F6 = 63,
    F7 = 64,
    F8 = 65,
    F9 = 66,
    F10 = 67,
    F11 = 68,
    F12 = 69,
    PrintScreen = 70,
    ScrollLock = 71,
    Pause = 72,
    Insert = 73,
    Home = 74,
    PageUp = 75,
    Delete = 76,
    End = 77,
    PageDown = 78,
    Right = 79,
    Left = 80,
    Down = 81,
    Up = 82,
    NumLockClear = 83,
    KeypadDivide = 84,
    KeypadMultiply = 85,
    KeypadMinus = 86,
    KeypadPlus = 87,
    KeypadEnter = 88,
    Keypad1 = 89,
    Keypad2 = 90,
    Keypad3 = 91,
    Keypad4 = 92,
    Keypad5 = 93,
    Keypad6 = 94,
    Keypad7 = 95,
    Keypad8 = 96,
    Keypad9 = 97,
    Keypad0 = 98,
    KeypadPeriod = 99,
    NonUs2 = 100, // Belg:<\> FrCa:«°» Dan:<\> Dutch:]|[ Fren:<> Ger:<|> Ital:<> LatAm:<> Nor:<> Span:<> Swed:<|> Swiss:<\> UK:\| Brazil: \|. Typically near the Left-Shift key in AT-102 implementations.
    Application = 101,
    Power = 102,
    KeypadEquals = 103,
    F13 = 104,
    F14 = 105,
    F15 = 106,
    F16 = 107,
    F17 = 108,
    F18 = 109,
    F19 = 110,
    F20 = 111,
    F21 = 112,
    F22 = 113,
    F23 = 114,
    F24 = 115,
    Execute = 116,
    Help = 117,
    Menu = 118,
    Select = 119,
    Stop = 120,
    Again = 121,
    Undo = 122,
    Cut = 123,
    Copy = 124,
    Paste = 125,
    Find = 126,
    Mute = 127,
    VolumeUp = 128,
    VolumeDown = 129,
    KeypadComma = 133,
    OtherKeypadEquals = 134, // Equals sign typically used on AS-400 keyboards.
    International1 = 135,
    International2 = 136,
    International3 = 137,
    International4 = 138,
    International5 = 139,
    International6 = 140,
    International7 = 141,
    International8 = 142,
    International9 = 143,
    Lang1 = 144,
    Lang2 = 145,
    Lang3 = 146,
    Lang4 = 147,
    Lang5 = 148,
    Lang6 = 149,
    Lang7 = 150,
    Lang8 = 151,
    Lang9 = 152,
    AlternativeErase = 153, // Example, Erase-Eaze™ key.
    SystemRequest = 154,
    Cancel = 155,
    Clear = 156,
    Prior = 157,
    Return2 = 158,
    Separator = 159,
    Out = 160,
    Oper = 161,
    ClearAgain = 162,
    // For more information on these two consult IBM's "3174 Establishment Controller - Terminal User's Reference for
    // Expanded Functions" (GA23-03320-02, May 1989)
    CursorSelect = 163,
    ExtendSelect = 164,
    Keypad00 = 176,
    Keypad000 = 177,
    ThousandsSeparator = 178,
    DecimalSeparator = 179,
    CurrencyUnit = 180,
    CurrencySubunit = 181,
    KeypadLeftParenthesis = 182,
    KeypadRightParenthesis = 183,
    KeypadLeftBrace = 184,
    KeypadRightBrace = 185,
    KeypadTab = 186,
    KeypadBackspace = 187,
    KeypadA = 188,
    KeypadB = 189,
    KeypadC = 190,
    KeypadD = 191,
    KeypadE = 192,
    KeypadF = 193,
    KeypadXor = 194,
    KeypadPower = 195,
    KeypadPercent = 196,
    KeypadLess = 197,
    KeypadGreater = 198,
    KeypadAmpersand = 199,
    KeypadDoubleAmpersand = 200,
    KeypadVerticalBar = 201,
    KeypadDoubleVerticalBar = 202,
    KeypadColon = 203,
    KeypadHash = 204,
    KeypadSpace = 205,
    KeypadAt = 206,
    KeypadExclamation = 207,
    KeypadMemoryStore = 208,
    KeypadMemoryRecall = 209,
    KeypadMemoryClear = 210,
    KeypadMemoryAdd = 211,
    KeypadMemorySubtract = 212,
    KeypadMemoryMultiply = 213,
    KeypadMemoryDivide = 214,
    KeypadPlusMinus = 215,
    KeypadClear = 216,
    KeypadClearEntry = 217,
    KeypadBinary = 218,
    KeypadOctal = 219,
    KeypadDecimal = 220,
    KeypadHexadecimal = 221,
    ControlLeft = 224,
    ShiftLeft = 225,
    AltLeft = 226,
    SuperLeft = 227,
    ControlRight = 228,
    ShiftRight = 229,
    AltRight = 230,
    SuperRight = 231,
    Mode = 257,
    // These values are mapped from usage page 0x0C (USB consumer page).
    Sleep = 258,
    Wake = 259,
    ChannelIncrement = 260,
    ChannelDecrement = 261,
    MediaPlay = 262,
    MediaPause = 263,
    MediaRecord = 264,
    MediaFastForward = 265,
    MediaRewind = 266,
    MediaNextTrack = 267,
    MediaPreviousTrack = 268,
    MediaStop = 269,
    MediaEject = 270,
    MediaPlayPause = 271,
    MediaSelect = 272,
    ApplicationNew = 273,
    ApplicationOpen = 274,
    ApplicationClose = 275,
    ApplicationExit = 276,
    ApplicationSave = 277,
    ApplicationPrint = 278,
    ApplicationProperties = 279,
    ApplicationSearch = 280,
    ApplicationHome = 281,
    ApplicationBack = 282,
    ApplicationForward = 283,
    ApplicationStop = 284,
    ApplicationRefresh = 285,
    ApplicationBookmarks = 286,
    // 501-512 is reserved for non-standard (i.e. not from an industry-standard HID page) keys.
    SoftLeft = 501, // Left button on mobile phones
    SoftRight = 502, // Right button on mobile phones
    Call = 503,
    EndCall = 504,
}

public enum KeyModifiers
{
    None = 0,
    ShiftLeft = 1 << 0,
    ShiftRight = 1 << 1,
    ControlLeft = 1 << 2,
    ControlRight = 1 << 3,
    AltLeft = 1 << 4,
    AltRight = 1 << 5,
    SuperLeft = 1 << 6,
    SuperRight = 1 << 7,
    NumLock = 1 << 8,
    CapsLock = 1 << 9
}
public interface IGamepad : IButtonDevice<JoystickButton>
{
    GamepadState State { get; }
    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => State.Buttons;
    IReadOnlyList<IMotor> VibrationMotors { get; }
}
public interface IMotor
{
    float Speed { get; set; }
}
public class GamepadState
{
    public ButtonReadOnlyList<JoystickButton> Buttons { get; }
    public DualReadOnlyList<Vector2> Thumbsticks { get; }
    public DualReadOnlyList<float> Triggers { get; }
}
public readonly struct DualReadOnlyList<T> : IReadOnlyList<T>
{
    public readonly T Left;
    public readonly T Right;
}
public interface IGamepadInputHandler : IButtonInputHandler<JoystickButton>
{
    void HandleThumbstickMove(GamepadThumbstickMoveEvent @event);
    void HandleTriggerMove(GamepadTriggerMoveEvent @event);
}
public interface IJoystick : IButtonDevice<JoystickButton>
{
    JoystickState State { get; }
    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => State.Buttons;
}
public class JoystickState
{
    public InputReadOnlyList<float> Axes { get; }
    public ButtonReadOnlyList<JoystickButton> Buttons { get; }
    public InputReadOnlyList<Vector2> Hats { get; }
}
public enum JoystickButton
{
    Unknown,
    ButtonDown,
    A = ButtonDown,
    ButtonRight,
    B = ButtonRight,
    ButtonLeft,
    X = ButtonLeft,
    ButtonUp,
    Y = ButtonUp,
    LeftBumper,
    RightBumper,
    Back,
    Start,
    Home,
    LeftStick,
    RightStick,
    DPadUp,
    DPadRight,
    DPadDown,
    DPadLeft
}
public interface IJoystickInputHandler : IButtonInputHandler<JoystickButton>
{
    void HandleAxisMove(JoystickAxisMoveEvent @event);
    void HandleHatMove(JoystickHatMoveEvent @event);
}
