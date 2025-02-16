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
    /// A console renderer which handles progress bar writing
    /// </summary>
    public class ConsoleRenderer
    {
        private readonly IProgressService _progressService;
        private readonly TextWriter _originalOut;
        private readonly StringWriter _consoleOutput;
        private readonly Timer _timer;
        private bool _isRunning = true;
        private int _progressBarCount;
        private readonly object _lockObject = new object();

        /// <summary>
        /// Creates and instance of the <see cref="ConsoleRenderer"/>
        /// </summary>
        /// <param name="progressService">the progress service</param>
        public ConsoleRenderer(IProgressService progressService)
        {
            _progressService = progressService;
            _originalOut = Console.Out;
            _consoleOutput = new StringWriter();
            Console.SetOut(_consoleOutput); // Redirect console output

            _timer = new Timer(Render, null, 0, 500);
        }

        /// <summary>
        /// Stops the console renderer processing and restores console to original state
        /// </summary>
        public void Stop()
        {
            _isRunning = false;
            _timer.Dispose();
            Console.SetOut(_originalOut); // Restore original output
        }

        private void Render(object? state)
        {
            if (!_isRunning && _consoleOutput.GetStringBuilder().Length > 0)
                return;

            lock (_lockObject)
            {
                // Clear the progress bars by moving the cursor and overwriting with spaces
                if (_progressBarCount > 0)
                {
                    int currentTop = Console.CursorTop;
                    Console.SetCursorPosition(0, currentTop - _progressBarCount);
                    for (int i = 0; i < _progressBarCount; i++)
                    {
                        _originalOut.Write(new string(' ', Console.WindowWidth));
                    }
                    Console.SetCursorPosition(0, currentTop - _progressBarCount);
                }

                var progressDictionary = _progressService.GetAllProgress();
                _progressBarCount = progressDictionary.Count();

                // Write all console output captured since the last render
                var output = _consoleOutput.GetStringBuilder().ToString();
                if (!string.IsNullOrWhiteSpace(output))
                {
                    _originalOut.Write(output);
                    _consoleOutput.GetStringBuilder().Clear();
                }

                foreach (var kvp in progressDictionary)
                {
                    string task = string.IsNullOrWhiteSpace(kvp.Value.Item1) ? string.Empty : $" - {kvp.Value.Item1}";
                    _originalOut.WriteLine($"{kvp.Key}{task}: ({new string('|', (int)(kvp.Value.Item2 * 20))}{new string('-', 20 - (int)(kvp.Value.Item2 * 20))}) ({(kvp.Value.Item2 * 100):F2}%)");
                }
            }
        }
    }
}
