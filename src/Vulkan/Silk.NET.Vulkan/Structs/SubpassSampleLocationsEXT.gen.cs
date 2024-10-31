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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSubpassSampleLocationsEXT")]
    public unsafe partial struct SubpassSampleLocationsEXT
    {
        public SubpassSampleLocationsEXT
        (
            uint? subpassIndex = null,
            SampleLocationsInfoEXT? sampleLocationsInfo = null
        ) : this()
        {
            if (subpassIndex is not null)
            {
                SubpassIndex = subpassIndex.Value;
            }

            if (sampleLocationsInfo is not null)
            {
                SampleLocationsInfo = sampleLocationsInfo.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpassIndex")]
        public uint SubpassIndex;
/// <summary></summary>
        [NativeName("Type", "VkSampleLocationsInfoEXT")]
        [NativeName("Type.Name", "VkSampleLocationsInfoEXT")]
        [NativeName("Name", "sampleLocationsInfo")]
        public SampleLocationsInfoEXT SampleLocationsInfo;
    }
}
