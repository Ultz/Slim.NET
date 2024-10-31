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
    [NativeName("Name", "XrCompositionLayerEquirect2KHR")]
    public unsafe partial struct CompositionLayerEquirect2KHR
    {
        public CompositionLayerEquirect2KHR
        (
            StructureType? type = StructureType.TypeCompositionLayerEquirect2Khr,
            void* next = null,
            CompositionLayerFlags? layerFlags = null,
            Space? space = null,
            EyeVisibility? eyeVisibility = null,
            SwapchainSubImage? subImage = null,
            Posef? pose = null,
            float? radius = null,
            float? centralHorizontalAngle = null,
            float? upperVerticalAngle = null,
            float? lowerVerticalAngle = null
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

            if (layerFlags is not null)
            {
                LayerFlags = layerFlags.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
            }

            if (eyeVisibility is not null)
            {
                EyeVisibility = eyeVisibility.Value;
            }

            if (subImage is not null)
            {
                SubImage = subImage.Value;
            }

            if (pose is not null)
            {
                Pose = pose.Value;
            }

            if (radius is not null)
            {
                Radius = radius.Value;
            }

            if (centralHorizontalAngle is not null)
            {
                CentralHorizontalAngle = centralHorizontalAngle.Value;
            }

            if (upperVerticalAngle is not null)
            {
                UpperVerticalAngle = upperVerticalAngle.Value;
            }

            if (lowerVerticalAngle is not null)
            {
                LowerVerticalAngle = lowerVerticalAngle.Value;
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
        [NativeName("Type", "XrCompositionLayerFlags")]
        [NativeName("Type.Name", "XrCompositionLayerFlags")]
        [NativeName("Name", "layerFlags")]
        public CompositionLayerFlags LayerFlags;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrEyeVisibility")]
        [NativeName("Type.Name", "XrEyeVisibility")]
        [NativeName("Name", "eyeVisibility")]
        public EyeVisibility EyeVisibility;
/// <summary></summary>
        [NativeName("Type", "XrSwapchainSubImage")]
        [NativeName("Type.Name", "XrSwapchainSubImage")]
        [NativeName("Name", "subImage")]
        public SwapchainSubImage SubImage;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "radius")]
        public float Radius;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "centralHorizontalAngle")]
        public float CentralHorizontalAngle;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "upperVerticalAngle")]
        public float UpperVerticalAngle;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "lowerVerticalAngle")]
        public float LowerVerticalAngle;
    }
}
