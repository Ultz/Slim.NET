// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Silk.NET.SilkTouch.Logging
{
    /// <summary>
    /// A custom logger for SilkTouch
    /// </summary>
    public class SilkLogger<T> : ILogger<T>
    {
        private readonly ILogger _innerLogger;
        private readonly JobContext _jobContext;

        /// <summary>
        /// creates an instance of <see cref="SilkLogger{T}"/>
        /// </summary>
        /// <param name="loggerfactory">instance of <see cref="ILoggerFactory"/> to generate internal logger</param>
        /// <param name="jobContext">context variable to keep track of current job</param>
        public SilkLogger(ILoggerFactory loggerfactory, JobContext jobContext)
        {
            _innerLogger = loggerfactory.CreateLogger<T>();
            _jobContext = jobContext;
        }

        /// <inheritdoc/>
        public IDisposable? BeginScope<TState>(TState state)
            where TState : notnull => _innerLogger.BeginScope(state);

        /// <inheritdoc/>
        public bool IsEnabled(LogLevel logLevel) => _innerLogger.IsEnabled(logLevel);

        /// <inheritdoc/>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel))
                return;

            var message = formatter(state, exception);
            var scope = _jobContext.JobKey;

            if (scope is not null)
            {
                var logFilePath = $"{scope}.log";
                if (!_jobContext.LogWriters.ContainsKey(logFilePath))
                {
                    if (File.Exists(logFilePath))
                        File.Delete(logFilePath);

                    _jobContext.LogWriters[logFilePath] = new StreamWriter(logFilePath, true) { AutoFlush = true };
                }

                var writer = _jobContext.LogWriters[logFilePath];
                lock (writer)
                {
                    writer.WriteLine($"{GetLogLevelString(logLevel)}: {typeof(T).FullName}[{eventId.Id}] => {message}");
                    if (exception != null)
                    {
                        writer.WriteLine(exception.ToString());
                    }
                }
            }
            // Delegate to the inner logger
            _innerLogger.Log(logLevel, eventId, state, exception, formatter);
        }

        private static string GetLogLevelString(LogLevel logLevel)
        {
            return logLevel switch {
                LogLevel.Trace => "trce",
                LogLevel.Debug => "dbug",
                LogLevel.Information => "info",
                LogLevel.Warning => "warn",
                LogLevel.Error => "fail",
                LogLevel.Critical => "crit",
                _ => throw new ArgumentOutOfRangeException(nameof(logLevel))
            };
        }
    }
}
