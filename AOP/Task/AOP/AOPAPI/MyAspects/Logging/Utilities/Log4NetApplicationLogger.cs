using log4net;
using log4net.Config;
using System.Reflection;
using System.Text;

namespace AOPAPI.MyAspects.Logging.Utilities
{
    public class Log4NetApplicationLogger : IApplicationLogger
    {
        private readonly ILog _log = LogManager.GetLogger("Logger");

        public Log4NetApplicationLogger()
        {
            var logRepo = LogManager.GetRepository(Assembly.GetExecutingAssembly());

            var configFile = new FileInfo(
                Path.Combine(AppContext.BaseDirectory, "log4net.config"));

            XmlConfigurator.Configure(logRepo, configFile);
        }

        public void LogDebug(string message)
        {
            _log.Debug(message);
        }

        public void LogError(Exception exception)
        {
            _log.Error(exception);
        }

        public void LogMethodEntry(string methodName, object[] parameters)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"[METHOD ENTRY] {methodName}");
            sb.AppendLine($"Parameters ({parameters.Length}):");

            for (int i = 0; i < parameters.Length; i++)
            {
                var param = parameters[i];

                sb.AppendLine(
                    $"  [{i}] {param?.GetType().Name ?? "null"} = {FormatValue(param)}");
            }

            _log.Debug(sb.ToString());
        }

        public void LogMethodExit(
            string methodName,
            object returnValue,
            long executionTimeMs)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"[METHOD EXIT] {methodName}");
            sb.AppendLine($"Return Value: {FormatValue(returnValue)}");
            sb.AppendLine($"Execution Time: {executionTimeMs}ms");

            _log.Debug(sb.ToString());
        }

        public void LogMethodException(
            string methodName,
            Exception exception,
            long executionTimeMs)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"[METHOD EXCEPTION] {methodName}");
            sb.AppendLine($"Exception: {exception.GetType().Name}");
            sb.AppendLine($"Message: {exception.Message}");
            sb.AppendLine($"Execution Time: {executionTimeMs}ms");

            _log.Error(sb.ToString(), exception);
        }

        private string FormatValue(object value)
        {
            if (value == null)
                return "null";

            if (value is string str)
                return $"\"{str}\"";

            if (value is IEnumerable<object> enumerable)
                return $"[{string.Join(", ", enumerable.Select(FormatValue))}]";

            return value.ToString();
        }
    }
}