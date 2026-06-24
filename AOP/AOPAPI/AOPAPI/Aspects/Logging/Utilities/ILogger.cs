namespace AOPAPI.Aspects.Logging.Utilities
{
    public interface ILogger
    {
        void LogDebug(string message);
        void LogError(Exception exception);
    }
}
