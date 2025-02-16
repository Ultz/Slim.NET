// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silk.NET.SilkTouch
{
    /// <summary>
    /// Information on the current Job
    /// </summary>
    public class JobContext
    {
        private readonly AsyncLocal<string?> _key = new AsyncLocal<string?>();

        /// <summary>
        /// The key for the relevant job
        /// </summary>
        public string? JobKey
        {
            get => _key.Value;
            set => _key.Value = value;
        }

        /// <summary>
        /// A dictionary of all current open log file writers
        /// </summary>
        public readonly ConcurrentDictionary<string, StreamWriter> LogWriters = new ConcurrentDictionary<string, StreamWriter>();
    }
}
