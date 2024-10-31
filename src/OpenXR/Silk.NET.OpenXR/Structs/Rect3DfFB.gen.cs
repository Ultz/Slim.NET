// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrRect3DfFB")]
    public unsafe partial struct Rect3DfFB
    {
        public Rect3DfFB
        (
            Offset3DfFB? offset = null,
            Extent3DfFB? extent = null
        ) : this()
        {
            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (extent is not null)
            {
                Extent = extent.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrOffset3DfFB")]
        [NativeName("Type.Name", "XrOffset3DfFB")]
        [NativeName("Name", "offset")]
        public Offset3DfFB Offset;
/// <summary></summary>
        [NativeName("Type", "XrExtent3DfFB")]
        [NativeName("Type.Name", "XrExtent3DfFB")]
        [NativeName("Name", "extent")]
        public Extent3DfFB Extent;
    }
}
