// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silk.NET.Core
{
    /// <summary>
    /// An interface to retrieve Native class Guids
    /// </summary>
    public unsafe interface INativeGuid
    {
        /// <summary>
        /// The guid for the native version of this class
        /// </summary>
        static abstract Guid* NativeGuid { get; }
    }
}
