// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public partial struct HRESULT
{
    public bool FAILED => Windows.FAILED(Value);
    public bool SUCCEEDED => Windows.SUCCEEDED(Value);
}
