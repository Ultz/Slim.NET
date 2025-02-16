# Summary

"Everything is an axis" - the idea that every input device can be abstracted into a series of axes (floating point values from 0-1), and an API for defining and working with such axes in a generic way.

# Contributors

- Dom Portera (@domportera)
- Dylan Perks (@Perksey)

# Current Status

- [x] Proposed
- [ ] Discussed with Community
- [ ] Approved
- [ ] Implemented

# Dependencies
This proposal assumes some knowledge of the [Multi-Backend Input proposal](./Proposal - Multi-Backend Input.md) and the previous version of this proposal.

# Background

This proposal is born of a conversation regarding the [Multi-Backend input proposal](./Proposal - Multi-Backend
Input.md), where the topic of "Every input is an axis" was brought up. This proposal is an attempt to flesh out that idea into a proper API and lay the foundation for how this could enable more advanced features in the future.

# Goals

The hopes is to put a small level of burden on backend implementations, thoughtfully implementing this API, we will:

- Make working with inputs more modular and consistent from both a high and low level
- Allow for both higher-level and lower-level common code and functionality
    - such as shared logic handling buttons, keys, accelerometers, gyroscopes, touchpads, etc
- Allow for creative uses of backend input systems
- Allow for the creation of simple or "free" input accessibility features
- Provide device-specific input descriptions without the need for the user to know what device or backend is in use
- Provide a foundation for future device-level key/button mapping
- Provide a foundation for to enable the creation of straightforward or automatic virtual device creation systems
- Enable the creation of extremely modular input systems, including the creation of virtual input devices, whereby an implementation could exist that allows for a straightforward, re-mappable implementation of device emulation
    - to be further fleshed out in a future proposal.
- Provide an API foundation for in-depth input accessibility features (related to the above-mentioned modularity)

# Note on Requirements
This proposal can be thought of in two primary areas: the API surface, and the implementation requirements. Wherever it was possible, the API surface was designed to enforce certain requirements, however there are quite a few requirements that must be followed that are not enforced by the API itself. Comments have been added to the API where these requirements are necessary and further detail is provided where needed. Feedback on clarity is welcome.

# Modifications to the Multi-Backend Input Proposal
We propose the following properties be added to `IInputDevice` for their general utility and to help keep this API and the [base input API](./Proposal - Multi-Backend
Input.md) consistent with each other.

```csharp
public interface IInputDevice : IEquatable<IInputDevice>
{
    // ---- Current API ----- //
    nint Id { get; } 
    string Name { get; }
    // ---------------------- //

    /// <summary>
    /// A human-readable description of the device, intended for end-user display
    /// </summary>
    public string? Description => null;

    /// <summary>
    /// A human-readable description of the device's status, intended for end-user display
    /// In the case of device malfunctions, especially those that are composed of multiple devices,
    /// this can be used to display any issues preventing the device from functioning properly
    /// </summary>
    public string? Status => null;
    
    /// <summary>
    /// False if this is a single real-world device, true if this is a device based on one or more physical devices,
    /// or is entirely virtual (e.g. a pointer in a VR environment, a virtual gamepad, etc)
    /// </summary>
    bool IsVirtual => false;
}
```

# Core API

The root of the API is in the interface `IAxisDevice`. This interface is essentially a host for collections of axes paired with definitions of these axes and how they relate to one another. 

It is important to note that the value of an input axis a single 32-bit floating point value. is primarily expected between 0-1.0. There are some axis types, or rather `AxisTrait`s, that are not straightforwardly normalized, and those respective axes can be labeled as such (more on that later).

## Device Validation
Due to the complex set of constraints detailed below, it is important that a validation layer exists to ensure that higher-level code can trust the device is following important conventions and constraints. As a result, each `IAxisDevice` must be validated, similar to Vulkan's validation layers, before `InputContext` can use the device to create a wrapper/implementation of the higher-level interfaces defined in Multi-Backend Input (or otherwise make use of the raw axes). This validation is done by `InputContext` if used, however if the user is using their own device aggregator type then it is important that the validation implementation is easily callable by those implementations due to its inevitable complexity.

This validation shall be exposed as follows:

```csharp
namespace Silk.NET.Input;
public partial interface IAxisDevice
{
    static sealed void Validate(IAxisDevice device);
}
```


## IAxisDevice

```csharp
/// <summary>
/// This represents a single input device, physical or virtual, that is comprised of a collection of axes (or floats)
/// The IReadOnlyList<float> interface is used to provide the normalized values of each axis, if it is indeed normalized (most should be). Otherwise, it would provide the raw, unnormalized value.
/// </summary>
public interface IAxisDevice : IReadOnlyList<float>, IInputDevice
{
    /// <summary>
    /// The main entry-point for useful information about common axis groups - e.g. joysticks, trackpads, buttons, gyros, etc.
    /// Turns single axes/floats into more broadly useable information
    /// Must be provided in order of <see cref="AxisGroup.Index"/>
    /// </summary>
    IReadOnlyList<AxisGroup> Groups { get; }

    /// <summary>
    /// The description of each axis in the hardware device
    /// This information is used primarily to allow for programmatically defined axis groups, axis devices, runtime validation,
    /// and custom device mappings and handling.
    /// Must be provided in order of <see cref="AxisDescription.Index"/>
    /// </summary>
    IReadOnlyList<AxisDescription> Axes { get; }

    /// <summary>
    /// Provides raw values for each axis as defined by the device's native API
    /// Must be provided in order of <see cref="AxisDescription.Index"/>
    /// </summary>
    IReadOnlyList<float> RawValues { get; }
}
```

## IAxisInputHandler

This is how a developer could subscribe directly to the axis changes of an `IAxisDevice`. It mimicks the `IGamepadInputHandler` interface from the [Multi-Backend Input proposal](./Proposal - Multi-Backend Input.md).

```csharp

/// <summary>
/// Represents the state of a single axis
/// </summary>
public readonly record struct AxisState(IAxisDevice Device, AxisDescription Description, float Value);

public interface IAxisInputHandler
{
    public void OnAxisChanged(in AxisState state);
}
```

## Axis Descriptions

There are two primary structures that give meaning to the axes of an `IAxisDevice`: `AxisDescription` and `AxisGroup`. The former defines the axes themselves, and the latter defines how these axes relate to one another. Note that both of these structures have an `Index` field, which must match the index of the `IAxisDevice`'s collection that it is defined in.

### Struct Definition

```csharp
/// <summary>
/// This describes a single axis on a device
/// </summary>
/// <param name="Index">the index of the axis in the device</param>
/// <param name="Traits">the traints of the axis, described above</param>
/// <param name="Name">A human-readable name for the axis</param>
///
/// <param name="IsAvailable">
/// If a given axis is unavailable for any reason during runtime, this would be marked as "false". This field is not included
/// in the validation process. <br/>
/// Axes with the <see cref="AxisTrait.Dynamic"/> flag are expected to make liberal use of this value in order to keep their axis indices consistent for the lifetime of each axis.
/// </param>
///
/// <param name="RawValueBounds">
/// The bounds of the raw value - a value of 'default' indicates it is typical (0, 1), or
/// in the case that the provided traits are <see cref="AxisTrait.RawValueOnly"/>, this must be default and indicates no known bounds.
/// </param>
public readonly record struct AxisDescription(
    int Index,
    AxisTrait Traits,
    string Name,
    bool IsAvailable = true,
    Vector2 RawValueBounds = default)
{
    public static implicit operator int(in AxisDescription description) => description.Index;
}
```

### Axis Traits
These are the primary flags through which an axis's use is defined. Its definition includes several constraints meant to both make defining axes less cumbersome and enforce logically consistent behaviour where possible. This enum is one of the primary places where validation needs to occur at runtime, and some flags place implementation requirements on the implementer. Wherever possible, we should seek to provide default implementations of expected behaviours regarding these constraints.

```csharp

/// <summary>
/// This is how individual axes are defined
/// Pay attention to the flags which require specific implementation details related to their RawValues and normalization
/// </summary>
[Flags]
public enum AxisTrait : ulong
{
    // To be treated as a default value / null. No axis should be left with this trait, and if they are it will be treated as an error or ignored.
    Unknown = 0,

    // Indicates that the axis is non-binary and has multiple values aside from 0 and 1.
    // Note: inputs with a finite set of values that aren't binary should either be marked as an Analog axis, or more likely be split into several Binary axes.
    Analog = 1 << 0,

    // This axis has two possible values - on/off, pressed/not pressed, 0 or 1. Implementations claiming a "Binary" axis trait will be expected to satisfy the condition that
    // The `Deadzone` will determine the default on/off behavior, which will default to `if(value > 0.0) return "on"`
    // The same default behavior will apply to any axis being treated as a Binary input, whether or not it has this trait.
    Binary = 1 << 1,

    // an analog axis that explicitly does not return to center or zero
    // things like touch-pads, mice, or world-space positions - NOT joysticks or triggers, as those would simply be marked as `Analog`
    Point = 1 << 2 | Analog | HasRawValue,

    // ---- Physical orientation ----
    Orientation = 1 << 2 | Analog, // indicates that this axis pertains to a real-world orientation of a device or tracked object
    Rotation = 1 << 3 | Orientation, // indicates that this axis pertains to a real-world rotation of a device or tracked object

    /// <summary>
    /// Indicates that this axis is a component of a euler angle in radians
    /// It is required you do NOT set <see cref="AxisDescription.RawValueBounds"/>, as it will be assumed to be *-pi, pi) The raw value must be pre-wrapped within range.
    /// this is specified because single axes of euler angle components can be useful by themselves,
    /// whereas anything shorter than 3 or 4 axes is not useful for quaternion rotation components
    /// </summary>
    EulerAngleComponent = 1 << 4 | Rotation | HasRawValue,

    /// <summary>
    /// Acceleration - in meters per second <br/>
    /// If this is set, it is expected that the axis is NOT provided any raw value constraints,
    /// as it is not expected to be normalized
    /// </summary>
    Acceleration = 1 << 6 | Orientation | RawValueOnly,

    /// <summary>
    /// Position - raw values are in meters if world-space, in pixels if screen-space, etc <br/>
    /// Normalized values are required if the bounds are known via the device's API.
    /// If they are unknown, this must be paired with <see cref="RawValueOnly"/>
    /// </summary>
    Position = 1 << 7 | Orientation | Point,
    // -----------------------------
  

    /// <summary>
    /// Used for axes that are on the left side of a device from the user's perspective.
    /// Useful for left/right handedness accommodation and various symmetrical devices. <br/><br/>
    /// For example: a left stick on a gamepad, a left trigger, a left shoulder button, the DPad on a gamepad, etc
    /// </summary>
    LeftSide = 1 << 12,

    /// <summary>
    /// Used for axes that are on the right side of a device from the user's perspective.
    /// Useful for left/right handedness accommodation and various symmetrical devices. <br/><br/>
    /// For example: a right stick on a gamepad, a right trigger, a right shoulder button, the face buttons on a gamepad, etc
    /// </summary>
    RightSide = 1 << 13,

  /// <summary>
    /// Indicates that the raw value provided for this axis is not the same as the normalized value. <br/>
    /// If this flag is signaled on an axis, it is highly recommended that the bounds are provided as well, even if they are infinite
    /// This can be useful for things like euler angle components, where single axes 0-360 degrees (or 0-2pi radians? do we want to standardize which?) can be useful by themselves
    /// </summary>
    HasRawValue = 1 << 58 | Analog,

    /// <summary>
    /// Indicates that there is no one-size-fits-all way to normalize this axis, and must be handled in a case-by-case basis <br/>
    /// Examples of this would be: <br/>
    /// - Accelerometers, as the relevant magnitude differs depending on the application <br/>
    /// - VR controller position without a bounding area <br/>
    /// - Quaternion rotation values, as these can be expected to be negative <br/>
    /// <br/>
    /// If this is set, it is expected that the axis is NOT provided any raw value constraints
    /// </summary>
    RawValueOnly = 1 << 59 | HasRawValue,

    /// <summary>
    /// Things like a mouse movement, trackpad, etc
    /// </summary>
    Delta = 1 << 60 | HasRawValue,

    /// <summary>
    /// Indicates that there is no one-size-fits-all way to normalize this axis, and must be handled in a case-by-case basis <br/>
    /// Examples of this would be: <br/>
    /// - Mouse position <br/>
    /// - Trackpad without an API for "absolute" position
    /// </summary>
    DeltaOnly = 1 << 61 | Delta | RawValueOnly,

    DeviceInformation = 1u << 62, // battery level, microphone level, etc


    /// <summary>
    /// Indicates that this axis has been added at runtime, and requires validation at first sight.
    /// Example use cases: touch pads and touch screens, the results of object sensors, etc
    /// As a result of being added at runtime, axes marked with this flag must not precede any axes not marked with this flag.
    /// Axes marked with this flag may not be included in any AxisGroup unless the AxisGroup is marked with the AxisGroupType.Dynamic flag as well.
    /// It is highly recommended that axes defined in this way be grouped in the same way one would group a struct - if multiple axes per-item (in this case, a finger)
    /// are present, these should be contiguous. for example, in the case of a touch surface:
    ///     Finger 1 begins at index i
    ///     i is an X component, i + 1 is a Y component, and i + 2 is a pressure component,
    ///     Finger 2 begins at i + 3 following the same pattern
    /// </summary>
    Dynamic = 1u << 63u,
}
```

### Example Definition List

The following is a demonstration of how this `AxisDescription` list could be populated by an input backend:

```csharp
public class DualsenseDevice : IAxisDevice
{
    IReadOnlyList<AxisDescription>
    private static readonly IReadOnlyList<AxisDescription> Axes =
    [
        // left analog stick
        new(0, AxisTrait.Analog | AxisTrait.LeftSide, "Left Joystick X-"),
        new(1, AxisTrait.Analog | AxisTrait.LeftSide, "Left Joystick X+"),
        new(2, AxisTrait.Analog | AxisTrait.LeftSide, "Left Joystick Y-"),
        new(3, AxisTrait.Analog | AxisTrait.LeftSide, "Left Joystick Y+"),
        new(4, AxisTrait.Binary | AxisTrait.LeftSide, "Left Joystick Press"),
        new(5, AxisTrait.Binary | AxisTrait.LeftSide, "Left Joystick Touch"),


        // right analog stick
        new(6, AxisTrait.Analog | AxisTrait.RightSide, "Right Joystick X-"),
        new(7, AxisTrait.Analog | AxisTrait.RightSide, "Right Joystick X+"),
        new(8, AxisTrait.Analog | AxisTrait.RightSide, "Right Joystick Y-"),
        new(9, AxisTrait.Analog | AxisTrait.RightSide, "Right Joystick Y+"),
        new(10, AxisTrait.Binary | AxisTrait.RightSide, "Right Joystick Press"),
        new(11, AxisTrait.Binary | AxisTrait.RightSide, "Right Joystick Touch"),

        // d-pad
        new(12, AxisTrait.Binary | AxisTrait.LeftSide, "D-Pad Left"),
        new(13, AxisTrait.Binary | AxisTrait.LeftSide, "D-Pad Right"),
        new(14, AxisTrait.Binary | AxisTrait.LeftSide, "D-Pad Down"),
        new(15, AxisTrait.Binary | AxisTrait.LeftSide, "D-Pad Up"),

        // face buttons
        new(16, AxisTrait.Binary | AxisTrait.RightSide, "Square"),
        new(17, AxisTrait.Binary | AxisTrait.RightSide, "Circle"),
        new(18, AxisTrait.Binary | AxisTrait.RightSide, "Cross"),
        new(19, AxisTrait.Binary | AxisTrait.RightSide, "Triangle"),

        // touchpad
        new(20, AxisTrait.Binary, "Touchpad Press"),

        // touchpad touch points - up to 4 touch points
        new(21, AxisTrait.Position, "Touchpad X1"),
        new(22, AxisTrait.Position, "Touchpad Y1"),
        new(23, AxisTrait.Position, "Touchpad X2"),
        new(24, AxisTrait.Position, "Touchpad Y2"),
        new(25, AxisTrait.Position, "Touchpad X3"),
        new(26, AxisTrait.Position, "Touchpad Y3"),
        new(27, AxisTrait.Position, "Touchpad X4"),
        new(28, AxisTrait.Position, "Touchpad Y4"),

        // select/start/home
        new(29, AxisTrait.Binary | AxisTrait.LeftSide, "Share"),
        new(30, AxisTrait.Binary | AxisTrait.RightSide, "Start"),
        new(31, AxisTrait.Binary, "Home"),

        // shoulder buttons
        new(32, AxisTrait.Binary | AxisTrait.LeftSide, "L1"),
        new(33, AxisTrait.Binary | AxisTrait.RightSide, "R1"),
        new(34, AxisTrait.Analog | AxisTrait.LeftSide, "L2"),
        new(35, AxisTrait.Analog | AxisTrait.RightSide, "R2"),

        // gyro
        new(36, AxisTrait.EulerAngleComponent, "Gyro X"),
        new(37, AxisTrait.EulerAngleComponent, "Gyro Y"),
        new(38, AxisTrait.EulerAngleComponent, "Gyro Z"),

        // accelerometer
        new(39, AxisTrait.Acceleration, "Accelerometer X"),
        new(40, AxisTrait.Acceleration, "Accelerometer Y"),
        new(41, AxisTrait.Acceleration, "Accelerometer Z"),

        // battery level
        new(42, AxisTrait.Analog, "Battery Level"),

        // microphone input level
        new(43, AxisTrait.Analog, "Microphone Level"),
    ];
}
 ```

As additional food for thought, a Sony Dualshock 2 controller whose face buttons are famously (though infrequently used as) analog, might contain face buttons with the following definition:

```csharp
_ = new AxisDescription(0, AxisTrait.Binary | AxisTrait.Analog | AxisTrait.RightSide, "Square");
```

## Axis Groups
`AxisGroup`s refer to collections of axes whose outputs or layouts are related to one another. If used smartly, they can be used to provide novel high-level remapping schemes, virtual devices, or other features.

### Struct Definition

```csharp
/// <summary>
/// This is the declaration of a group of axes within a specific device
/// </summary>
/// <param name="Index">Index within the list of <see cref="AxisGroup"/>s</param>
/// <param name="Purpose">The intended purpose of this group</param>
/// <param name="Axes">The indices of the axes that make up this group</param>
/// <param name="TwinIndex">The AxisGroup index of the "twin" of this group - e.g. if this is the left thumbstick, the twin would be the right thumbstick</param>
/// <param name="Name">A human-readable name for the group</param>
/// <remarks>Can names be inferred at runtime from the AxisDescription and AxisGroup? Should they be nullable/optional
/// in the definition and then populated at runtime if they're missing?</remarks>
public readonly record struct AxisGroup(
    int Index,
    AxisGroupType Purpose,
    IReadOnlyList<int> Axes,
    int? TwinIndex = null,
    string Name = "Unknown")
{
    public static implicit operator int(AxisGroup group) => group.Index;
}
```

### Axis Group Types
`AxisGroupType` is the primary way in which an `AxisGroup` is given meaning. It is how analog sticks, touchpads, DPads, mouse travel, etc are defined. 

Like `AxisDescription`, it contains hard-coded constraints to help ensure that groups are defined correctly. It also has a few flags that enforce certain requirements on the implementer. We should strive to provide default implementations of expected behaviours regarding these constraints wherever possible. This is another important source of information that must be validated at runtime.



```csharp
/// <summary>
/// This is how one defines the purpose of groups of multiple axes in a device
/// It has specifications that must be followed to be considered valid
/// </summary>
[Flags]
public enum AxisGroupType : ulong

{
    // To be treated as a default value / null. No axis should be left with this trait, and if they are it will be treated as an error or ignored.
    Unknown = 0u,

    // an ordering convention for family axes is left/right/bottom/top/back/forward - "negative" to "positive" values

    // (West, East, South, North) / (Left, Right, Down, Up) / (X, B, A, Y) - xbox / (square, circle, cross, triangle) - playstation
    // 4 independent axes using the ordering convention above
    DiamondActionButtons = 1u << 1,

    // Two buttons standardly used as confirmation or rejection of a given selection
    // things like A & B buttons, X & circle buttons, Enter and Backspace/ESC, etc
    ConfirmReject = 1 << 2

    // Specified in addition to DiamondActionButtons due to the constraints often placed on DPad axes from a hardware level
    // 2 Axes, (X, Y) (-1, 1)
    // made of 4 physical axes, (X-, X+, Y-, Y+)
    DPad = 1u << 3 | DiamondActionButtons,

    /// <summary>
    /// 1D joystick, 1 logical axis, (-1, 1) - intended to allow mapping to a particular physical axis (XYZ) of a 2D+ joystick, or to represent a 1-dimensional input stick
    /// made of 2 physical axes, (X-, X+)
    /// More physically resembling a "lever" than a joystick if not a component of a 2D+ joystick
    /// </summary>
    JoystickAxis = 1u << 4 | DPad,

    /// <summary>
    /// 2D joystick, 2 logical axes, (X, Y) (-1, 1)
    /// made of 4 physical axes, (X-, X+, Y-, Y+)
    /// If constructed with 5 axes, the 5th axis is the "pressure" axis for a pointer
    /// More abstractly, this is a Position2D that returns to 0,0 when released
    /// </summary>
    Joystick2D = 1u << 5 | Position2D | DPad,

    /// <summary>
    /// 3D joystick
    /// 3 logical Axes (X, Y, Z), (-1, 1)
    /// made of 6 physical axes, (X-, X+, Y-, Y+, Z-, Z+)
    /// If constructed with 7 axes, the 7th axis is the "pressure" axis for a pointer
    /// Can be used for analog stick with a press-in button, or a 3D mouse, etc
    /// More abstractly, this is a Position3D that returns to 0,0,0 when released
    /// </summary>
    Joystick3D = 1u << 6 | Position3D,
    
    /// <summary>
    /// 1D touch surface or tracker axis - intended to allow mapping to an individual axis of a 2D+ position surface, or to represent a 1D touch strip, trackball, & similar
    /// 1 logical axis, (-1, 1)
    /// made of 2 physical axes, (-X, +X).
    /// If constructed with 3 axes, the 3rd axis is the "pressure" axis for a pointer
    /// </summary>
    PositionAxis = 1u << 7,

    /// <summary>
    /// 2D touch surface or tracker
    /// 2 logical axes, (X, Y) (-1, 1)
    /// made of 4 physical axes (-X, +X, -Y, +Y)
    /// If constructed with 5 axes, the 5th axis is the "pressure" axis for a pointer
    /// * Request for feedback: do we want to allow this to be defined with 2 "physical" axes as well?
    /// Wherein if it is provided with 3 "physical" axes, the 3rd is the "pressure" axis
    /// </summary>
    Position2D = 1u << 8,

    /// <summary>
    /// 3D touch surface or tracker, 3 logical axes, (X, Y, Z)
    /// made of 6 physical axes (-X, +X, -Y, +Y, -Z, +Z)
    /// If constructed with 7 axes, the 7th axis is the "pressure" axis for a pointer
    /// * Request for feedback: do we want to allow this to be defined with 3 "physical" axes as well?
    /// Wherein if it is provided with 4 "physical" axes, the 4th is the "pressure" axis
    /// </summary>
    Position3D = 1u << 9,

    // XYZ order, aka (pitch, yaw, roll)
    RotationEuler = 1u << 10, // gyroscope, gyroscope + magnetomete, VR peripheral rotation - requires 3 axes, XYZ order

    RotationQuaternion =
        1u << 11, // gyroscope, gyroscope + magnetomete, VR peripheral rotation - requires 4 axes, XYZW order

    Accelerometer = 1u << 12, // 3D accelerometer, requires 3 axes, XYZ order

    LeftHanded = 1u << 13, // allowing for left/right swap of symmetrical devices and labeling left/right buttons
    RightHanded = 1u << 14, // allowing for left/right swap of symmetrical devices

    /// <summary>
    /// Indicates that this axis has been added at runtime, and requires validation at first sight.
    /// Example use cases: touch pads and touch screens, the results of object sensors, etc
    /// As a result of being added at runtime, groups marked with this flag must not precede any groups not marked with this flag.
    /// </summary>
    Dynamic = 1u << 63,
}
```

### Axis Group Directional Convention
This pertains to `AxisGroupType`s that suggest positional input - i.e. `DiamondActionButtons`, `DPad`, `Joystick1D`, `Joystick2D`, `Joystick3D`, `Position1D`, `Position2D`, `Position3D`, `RotationEuler`, `RotationQuaternion`, and `Accelerometer`. The convention is as follows:

Note that `AxisGroup` sets a standard for dealing with multi-dimensional axes, which dictates the order in which `AxisGroup.Axes` is populated by `AxisDescription` indices. The convention to be followed by all comparable axis groups is as follows:

- Axes are intended to be ordered in the following way:
  - Typical 3D axis notation is to be followed (X, Y, Z), with Y being the vertical axis
  - Within a single "physical" axis (i.e.. X, Y, etc) "Negative" values come before "positive" values. Or, in other words, "Left" before "Right", "Down" before "Up", "Back" before "Forward".
  - Irregular controllers might be up to interpretation, but the convention should be followed as closely as possible, primarily with respect to the actual physical device, rather than convention.


The following is a chart laying out example orderings for different axis groups.

| Hardware inputs                                                                                                                                                                                | Axis ordering for `AxisGroup` _______________________________________________________________________________________                                                                                                                                                                                            |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ![DPad buttons](https://upload.wikimedia.org/wikipedia/commons/4/4d/D-Pad_of_an_Xbox_One_controller.jpg)                                                                                       | (Left, Right, Down, Up)                                                                                                                                                                                                                                                                                          |
| ![Analog stick](https://upload.wikimedia.org/wikipedia/commons/a/a9/GameCube_Analog_Stick.jpg)                                                                                                 | (Left, Right, Down, Up)<br/> (X-, X+, Y-, Y+)                                                                                                                                                                                                                                                                    |
| ![gamecube face buttons](https://upload.wikimedia.org/wikipedia/commons/d/da/Gamecube_controller_face_buttons.jpg)                                                                             | (B, X, A, Y)                                                                                                                                                                                                                                                                                                     |
| ![playstation face buttons](https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/PlayStation_original_controller_face_buttons.jpg/684px-PlayStation_original_controller_face_buttons.jpg) | (Square, Circle, Cross, Triangle)                                                                                                                                                                                                                                                                                |
| ![N64 face buttons](https://upload.wikimedia.org/wikipedia/commons/4/48/Nintendo_64_controller_face_buttons.jpg)                                                                               | Primary - (C Left, C Right, C Down, C Up)<br/><br/>Secondary - (B, C down, A, C left)                                                                                                                                                                                                                            |
| ![WASD keys](https://upload.wikimedia.org/wikipedia/commons/0/05/Cursor_keys--WASD.svg)                                                                                                        | (A, D, S, W)<br/> Arrow keys would be (left, right, down, up of course)<br/>(J, L, K, I), etc                                                                                                                                                                                                                    |
| ![Fight stick](https://upload.wikimedia.org/wikipedia/commons/8/8f/Wii_Arcade_Stick.png?20200918233300)                                                                                        | The "face" buttons are not a candidate for `AxisGroupType.DiamondActionButtons` designation due to their layout, so fight sticks and some other retro controllers would likely exclude their face buttons from any particular axis group<br/><br/>The joystick would of course be (-X Left, +X Right, -Y Down, +Y Up) |
| ![Accelerometer](https://cdn.phidgets.com/docs/images/9/96/Accelerometer_Intro.jpg) | (X, Y, Z)                                                                                                                                                                                                                                                                                                        |
| ![Gyroscope](https://upload.wikimedia.org/wikipedia/commons/b/b8/Roll_Pitch_Yaw.JPG) | Euler representation: (pitch, yaw, roll)<br/><br/>Quaternion representation: (X, Y, Z, W)                                                                                                                                                                                                                        |

As you may have gathered, a single axis can be assigned multiple axis groups. This is perfectly legal and *encouraged*. However, the ordering of such groups can become significant to users of the device.

In general, the larger order of axis groups is not significant except for the following:

- If a specific axis is a member of more than one axis group, they are assumed to be ordered in order of primacy for that particular axis.
  - Note that this ordering is *relative* - they do not need to be defined in consecutive order.
- If two or more `AxisGroup`s share the precise same `AxisGroupType` (all flags included), then some implementations are fair to assume they are in order of their primacy as well.

Though it is possible (and often recommended) to use `AxisGroupType` as flags, including every supported `AxisGroupType` associated with a set of axes, doing so is not required. It may be advantageous to utilize the above ordering constraint in order to define a preference for a particular set of axes to be used as a specific `AxisGroupType`. For example, defining a D-Pad on a controller that could be defined as:

```csharp
new(3, AxisGroupType.DPad | AxisGroupType.DiamondActionButtons | AxisGroupType.LeftHanded, [14, 15, 16, 17], 6, "D-Pad"),
```

could instead be defined as:
```csharp
new(3, AxisGroupType.DPad | AxisGroupType.LeftHanded, [14, 15, 16, 17], 6, "D-Pad"),
new(4, AxisGroupType.DiamondActionButtons | AxisGroupType.LeftHanded, [14, 15, 16, 17], 6, "D-Pad"),
```
As previously stated, the latter grants you the benefit of having a defined order of primacy for the axes in the D-Pad group, which can be useful for certain implementations.


Though no such API is defined in this proposal, the Silk.NET team reserves the right to expose extension methods to aid in determining the "ranking" of `AxisGroup`s for any given axis, as well as determining the "default" set of axis groups that make up a given device.


### Example Axis Group List

Below is an incomplete example of how an `AxisGroup` list can be populated.

```csharp
private static readonly IReadOnlyList<AxisGroup> Groups =
[
    new(0, AxisGroupType.Joystick2D | AxisGroupType.LeftHanded, [0, 1, 2, 3], 1, "Left Joystick"),
    new(1, AxisGroupType.Joystick2D | AxisGroupType.RightHanded, [4, 5, 6, 7], 0, "Right Joystick"),
    new(3, AxisGroupType.DPad | AxisGroupType.DiamondActionButtons | AxisGroupType.LeftHanded, [14, 15, 16, 17], 6, "D-Pad"),
    new(4, AxisGroupType.DiamondActionButtons | AxisGroupType.RightHanded, [30, 31, 32, 33], 5, "Face     Buttons"),
    new(5, AxisGroupType.Position2D, [18, 19], null, "Touchpad"),
    new(6, AxisGroupType.Unknown, [20, 21], null, "Unknown")
];

IReadOnlyList<AxisGroup> IAxisDevice.Groups => Groups;
```


# Deadzones

With this proposal, I thought it pertinent to define a base "Deadzone" API. Using this, we can create specific implementations to turn `AxisTrait.Analog` axes into a binary button signal, or of course implement traditional joystick-related deadzones and handle other noisy inputs

## The Struct

```csharp

/// <summary>
/// Represents a deadzone for an axis
/// ExpectedNoise can be ignored by deadzone implementations, but is relevant for those involving
/// logic-oriented debouncing
/// </summary>
public record struct Deadzone
{
    public Vector2 Zone;
    public float ExpectedNoise;

    /// <summary>
    /// If true, the deadzone will be skipped entirely, and values within the deadzone will be treated as 0.
    /// Values just outside the deadzone will be treated as their literal value.
    ///
    /// More commonly, if false, IDeadzoneHandlers will treat the outer values as a full normalizable range.
    /// For example, if an axis has a deadzone of (0.25, 0.75),
    /// then 0.0 - 0.25 would be treated as 0.0 - 0.5, and 0.75 - 1.0 would be treated as 0.5 - 1.0
    /// </summary>
    public bool SkipDeadValues;

    public Deadzone(Vector2 zone, float expectedNoise, bool skipDeadValues = false)
    {
        Zone = zone;
        ExpectedNoise = expectedNoise;
        SkipDeadValues = skipDeadValues;
    }

    public Deadzone(float minimum, float expectedNoise, bool skipDeadValues = false)
    {
        Zone = new Vector2(minimum, 1);
        ExpectedNoise = expectedNoise;
        SkipDeadValues = skipDeadValues;
    }

    public Deadzone(float minimum, bool skipDeadValues = false)
    {
        Zone = new Vector2(minimum, 1);
        ExpectedNoise = 0;
        SkipDeadValues = skipDeadValues;
    }
}
```

## The Handlers

```csharp
/// <summary>
/// An interface for handling deadzones in different ways
/// </summary>
public interface IDeadzoneHandler
{
public float GetValue(IAxisDevice device, int descriptionIndex, Deadzone deadzone);
public bool IsInDeadzone(IAxisDevice device, int descriptionIndex, Deadzone deadzone);

    public bool IsGroupInDeadzone(IAxisDevice device, int groupIndex, Deadzone deadzone);
    
    // Requires that the length of the deadzones span matches the number of axes in the group
    public bool IsGroupInDeadzone(IAxisDevice device, int groupIndex, ReadOnlySpan<Deadzone> deadzones);
}
```

# Outputs
Many controllers have haptics, LEDs, etc, that would be nice to access in a generic, normalized way as well. The following is a first draft concept for this functionality that could accomplish this while leaving room for different sorts of outputs later on. 

Feedback requested: is custom data handling necessary here? At that point it violates the "axis" concept pretty strongly and is best served by higher-level interfaces, but I wanted to make sure we at least consider these things.

```csharp
public partial interface IAxisDevice
{
    /// <summary>
    /// Output definitions for this device - commonly haptics, LEDs, etc
    /// </summary>
    IReadOnlyList<OutputDescription> Outputs { get; }

    // for groups of outputs, e.g. all LEDs, all vibration motors, left side vibration motors, etc
    IReadOnlyList<OutputGroup> OutputGroups { get; }
    
    /// <summary>
    /// Allows the caller to set an output value for a specific output index.
    /// Valid for any axis not marked as <see cref="OutputAxisTrait.RawDataOnly"/>.
    /// </summary>
    public void SetOutput(int index, float value);
    
    /// <summary>
    /// Allows the caller to set an output value(s) for a non-floating-point output.
    /// Valid only for axes marked as <see cref="OutputAxisTrait.RawDataOnly"/>.
    /// Requires that the caller knows the correct data type for the output, and as such the implementation must throw
    /// an exception if the data type is not correct.
    /// <br/><br/>
    /// More than likely, concrete implementations or higher-level interfaces will provide a safer way to set these
    /// sorts of values. The absence of higher-level utilities for this method should be considered a missing feature
    /// if the implementation utilizes <see cref = "OutputAxisTrait.RawDataOnly"/>.
    ///<br/><br/>
    /// It is more or less expected that this will have few, if any, implementations in the early stages of this API.
    /// Its use is reserved for advanced use-cases or higher-level implementations where the caller knows the exact
    /// data type required the output - for example, setting a specific bit pattern for a specific LED, driving
    /// embedded displays, built-in speakers, etc.
    /// </summary>
    /// <param name="index">The index of the <see cref="OutputDescription"/> in <see cref="Outputs"/></param>
    /// <param name="values">A pointer to the value(s) to be set</param>
    public void SetOutput<T>(int index, T* values, int count = 1) where T : unmanaged => throw new NotImplementedException();
}

public enum OutputTrait : ulong
{
    None = 0,
    LED = 1u << 0,
    Haptic = 1u << 1,
    
    ForceFeedback = 1u << 2 | Haptic,
    VibrationMotor = 1u << 3 | Haptic,

    /// <summary>
    /// For firmware-controlled device settings, such as microphone gain, calibration parameters, etc. Necessarily requires additional descriptors that should be expanded upon in this or another proposal.
    /// In the case of a "virtual" device, this could apply to any device setting that is specific to that device. 
    /// </summary>
    DeviceControl = 1u << 4.
    
    RawDataOnly = AxisTrait.RawValueOnly,
    LeftSide = AxisTrait.LeftSide,
    RightSide = AxisTrait.RightSide
}


/// <summary>
/// The definition of an output of an <see cref="IAxisDevice"/>
/// </summary>
public readonly record struct OutputDescription
{
    /// <summary>
    /// The index of this output in <see cref="IAxisDevice.Outputs"/>
    /// </summary>
    public int Index { get; init; }

    public OutputTrait Traits { get; init; }

    /// <summary>
    /// An associated axis index if one exists - for example, force feedback for a
    /// specific trigger, an LED for a specific button, etc.
    /// </summary>
    public int? AssociatedAxisIndex { get; init; }

    /// <summary>
    /// An optional name for the output
    /// </summary>
    public string? Name { get; init; }

    public bool IsAvailable {get; init;}
    
    /// <summary>
    /// The definition of an output of an <see cref="IAxisDevice"/>
    /// </summary>
    /// <param name="index">The index of this output in <see cref="IAxisDevice.Outputs"/></param>
    /// <param name="traits">The traits of this output</param>
    /// <param name="associatedAxisIndex">An associated axis index if one exists - for example, force feedback for a
    /// specific trigger, an LED for a specific button, etc.</param>
    /// <param name="name">An optional name for the output</param>
    public OutputDescription(int index, OutputTrait traits, int? associatedAxisIndex = null, string? name = null, bool isAvailable = true)
    {
        Index = index;
        Traits = traits;
        AssociatedAxisIndex = associatedAxisIndex;
        Name = name;
        IsAvailable = isAvailable;
    }
}

public readonly record struct OutputGroup(int index, OutputAxisGroupType Purpose, IReadOnlyList<int> AssociatedOutputs, string? Name = null

public enum OutputGroupType : ulong
{
    None = 0,

    // Indicates that this group controls an LED or group of LEDs
    // Depending on <see cref="OutputGroup.AssociatedOutputs"/> length:
    // length == 1, this is brightness
    // length == 3, RGB
    // length == 4, RGBA (RGB + Brightness)
    LED = 1u << 0,

    Haptics = 1u << 1,
    Vibration = 1u << 2 | Haptics


    LeftSide = AxisGroupType.LeftHanded, // allowing for left/right swap of symmetrical devices
    RightSide = AxisGroupType.RightHanded, // allowing for left/right swap of symmetrical devices

    /// <summary>
    /// Indicates that this axis has been added at runtime, and requires validation at first sight.
    /// Example use cases: touch pads and touch screens, the results of object sensors, etc
    /// As a result of being added at runtime, groups marked with this flag must not precede any groups not marked with this flag.
    /// </summary>
    Dynamic = AxisGroupType.Dynamic,
}
```
