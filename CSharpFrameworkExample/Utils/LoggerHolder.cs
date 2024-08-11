using NLog;

namespace CSharpFrameworkExample.Utils;

public static class LoggerHolder
{
    private static readonly Dictionary<string, Logger> _holder = new();

    public static void Add(string testId, Logger logger)
    {
        _holder.Add(testId, logger);
    }

    public static Logger Get(string testId)
    {
        return _holder[testId];
    }

    public static void Rewrite(string testId, Logger logger)
    {
        try
        {
            _holder[testId] = logger;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static void Remove(string testId)
    {
        _holder.Remove(testId);
    }
}