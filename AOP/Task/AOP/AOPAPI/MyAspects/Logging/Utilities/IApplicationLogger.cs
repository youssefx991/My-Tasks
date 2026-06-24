namespace AOPAPI.MyAspects.Logging.Utilities
{
    public interface IApplicationLogger
    {
        void LogDebug(string message);
        void LogError(Exception exception);
        void LogMethodEntry(string methodName, object[] parameters);
        void LogMethodExit(string methodName, object returnValue, long executionTimeMs);
        void LogMethodException(string methodName, Exception exception, long executionTimeMs);
    }
}