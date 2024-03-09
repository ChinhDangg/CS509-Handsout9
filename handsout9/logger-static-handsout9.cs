using System;

public static class Logger {
    public static void Log(LogLevel level, string message) {
        switch (level) {
            case LogLevel.Comment:
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case LogLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case LogLevel.Error:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            default:
                break;
        }

        Console.WriteLine($"{level}: {message}");

        if (level == LogLevel.Error) {
            Environment.Exit(1);
        }
    }
}

public enum LogLevel
{
    Comment,
    Warning,
    Error
}

class Program {
    static void Main(string[] args) {
        // Example usage:
        Logger.Log(LogLevel.Comment, "Comment message");
        Logger.Log(LogLevel.Warning, "Warning message");
        Logger.Log(LogLevel.Error, "Error message");

        Logger.Log(LogLevel.Comment, "Unreachable");
    }
}