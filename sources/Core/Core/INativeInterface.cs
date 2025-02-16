// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core
{
    /// <summary>
    /// Represents a native interface structure
    /// </summary>
    public unsafe interface INativeInterface
    {
        /// <summary>
        /// Gets the address of  the pointer to the interface object address
        /// </summary>
        /// <typeparam name="TNativeInterface">The native interface object type</typeparam>
        /// <returns>pointer to interface object address </returns>
        Ptr2D<TNativeInterface> GetAddressOf<TNativeInterface>() where TNativeInterface : unmanaged;
        /// <summary>
        /// Gets the address of  the pointer to the interface object address
        /// </summary>
        /// <returns>pointer to interface object address </returns>
        Ptr2D GetAddressOf();
    }
}
