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
    [NativeName("Name", "XrHandJointLocationsEXT")]
    public unsafe partial struct HandJointLocationsEXT
    {
        public HandJointLocationsEXT
        (
            StructureType? type = StructureType.TypeHandJointLocationsExt,
            void* next = null,
            uint? isActive = null,
            uint? jointCount = null,
            HandJointLocationEXT* jointLocations = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (isActive is not null)
            {
                IsActive = isActive.Value;
            }

            if (jointCount is not null)
            {
                JointCount = jointCount.Value;
            }

            if (jointLocations is not null)
            {
                JointLocations = jointLocations;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isActive")]
        public uint IsActive;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "jointCount")]
        public uint JointCount;
/// <summary></summary>
        [NativeName("Type", "XrHandJointLocationEXT*")]
        [NativeName("Type.Name", "XrHandJointLocationEXT")]
        [NativeName("Name", "jointLocations")]
        public HandJointLocationEXT* JointLocations;
    }
}
