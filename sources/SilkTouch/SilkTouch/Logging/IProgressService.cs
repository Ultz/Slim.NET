// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silk.NET.SilkTouch.Logging
{
    /// <summary>
    /// An interface for handling current task progress in a job
    /// </summary>
    public interface IProgressService
    {
        /// <summary>
        /// Returns an enumerable of all progress values with job as the key, and then the task and progress in a tuple
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValuePair<string, (string, float)>> GetAllProgress();
        /// <summary>
        /// Get the current task and progress for this job
        /// </summary>
        /// <returns>current task and progress for this job</returns>
        (string, float) GetCurrentTaskAndProgress();
        /// <summary>
        /// Set the name of the task for this job
        /// Resets the progress to 0
        /// </summary>
        /// <param name="task">name of the current task</param>
        void SetTask(string task);
        /// <summary>
        /// Sets the progress of the current job's task
        /// Values are expected between 0 and 1
        /// </summary>
        /// <param name="progress">current progress value</param>
        void SetProgress(float progress);
        /// <summary>
        /// Remove the current job from the progress service
        /// </summary>
        void RemoveProgress();
    }
}
