using static System.String;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] newLogLine = logLine.Split(':');
        return newLogLine[1].Replace("\n", "").Replace("\r", "").Trim();
    }
    public static string LogLevel(string logLine)
    {
        string[] newLogLine = logLine.Split(':');
        return newLogLine[0].ToLower().Replace("[", Empty).Replace("]",Empty);
    }

    public static string Reformat(string logLine)
    {
        int finalLength = LogLevel(logLine).Length + 1;
        string[] newLogLine = logLine.Split(':');
        return Concat(Message(logLine)," ", LogLevel(logLine).Insert(0,"(").Insert(finalLength,")"));

    }
}
