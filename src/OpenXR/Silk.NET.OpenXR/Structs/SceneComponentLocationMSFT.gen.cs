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
    [NativeName("Name", "XrSceneComponentLocationMSFT")]
    public unsafe partial struct SceneComponentLocationMSFT
    {
        public SceneComponentLocationMSFT
        (
            SpaceLocationFlags? flags = null,
            Posef? pose = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pose is not null)
            {
                Pose = pose.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSpaceLocationFlags")]
        [NativeName("Type.Name", "XrSpaceLocationFlags")]
        [NativeName("Name", "flags")]
        public SpaceLocationFlags Flags;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
    }
}
