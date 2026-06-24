using log4net;
using log4net.Config;
using System.Reflection;

namespace AOPAPI.Aspects.Logging.Utilities
{
    public class Log4NetLogger : ILogger
    {
        private readonly ILog _log = LogManager.GetLogger("Logger");

        public Log4NetLogger()
        {
            var logRepo = LogManager.GetRepository(Assembly.GetExecutingAssembly());
            var configFile = new FileInfo(Path.Combine(AppContext.BaseDirectory, "log4net.config"));
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
    }
}
