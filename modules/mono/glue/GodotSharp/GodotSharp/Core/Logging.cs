
using System;

#nullable enable

namespace Godot;

/// <summary>
/// Functionality to intercept and handle engine log messages.
/// </summary>
public static class Logging
{
    public static event Action<Exception>? UserExceptionReporter;

    internal static void InvokeUserExceptionReporter(Exception e)
    {
        UserExceptionReporter?.Invoke(e);
    }
}
