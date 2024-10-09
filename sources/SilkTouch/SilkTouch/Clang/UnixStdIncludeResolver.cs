﻿using System.Collections.Generic;
using System.Linq;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Resolver for the C standard include paths on UNIX-like systems. On UNIX this is remarkably simple, it's just
/// /usr/include and /usr/include/local.
/// </summary>
public class UnixStdIncludeResolver : IStdIncludeResolver
{
    private string[]? _ret = null;

    /// <inheritdoc />
    public IEnumerable<string> GetStandardIncludes() =>
        _ret ??= CoreGetStandardIncludes().ToArray();

    /// <inheritdoc cref="GetStandardIncludes" />
    protected virtual IEnumerable<string> CoreGetStandardIncludes()
    {
        yield return "-I/usr/include";
        yield return "-I/usr/local/include";
    }
}
