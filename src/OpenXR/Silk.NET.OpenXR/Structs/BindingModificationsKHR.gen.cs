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
    [NativeName("Name", "XrBindingModificationsKHR")]
    public unsafe partial struct BindingModificationsKHR
    {
        public BindingModificationsKHR
        (
            StructureType? type = StructureType.TypeBindingModificationsKhr,
            void* next = null,
            uint? bindingModificationCount = null,
            BindingModificationBaseHeaderKHR** bindingModifications = null
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

            if (bindingModificationCount is not null)
            {
                BindingModificationCount = bindingModificationCount.Value;
            }

            if (bindingModifications is not null)
            {
                BindingModifications = bindingModifications;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bindingModificationCount")]
        public uint BindingModificationCount;
/// <summary></summary>
        [NativeName("Type", "XrBindingModificationBaseHeaderKHR**")]
        [NativeName("Type.Name", "XrBindingModificationBaseHeaderKHR")]
        [NativeName("Name", "bindingModifications")]
        public BindingModificationBaseHeaderKHR** BindingModifications;
    }
}
