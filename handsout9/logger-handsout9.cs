using System;

public sealed class Logger
{
    private static readonly Logger instance = new Logger();

    private Logger() {
    }

    public static Logger Instance {
        get {
            return instance;
        }
    }

    public void Log(LogLevel level, string message) {
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

class Program
{
    static void Main(string[] args)
    {
        Logger logger = Logger.Instance;

        logger.Log(LogLevel.Comment, "Comment message");
        logger.Log(LogLevel.Warning, "Warning message");
        logger.Log(LogLevel.Error, "Error message");
        
        logger.Log(LogLevel.Comment, "Unreachable");
    }
}