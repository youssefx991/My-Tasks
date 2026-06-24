using Castle.DynamicProxy;

namespace AOPAPI.Aspects.Logging.Interceptor
{

    public class LoggingInterceptor : IInterceptor
    {
        private readonly ILogger _logger;

        public LoggingInterceptor(ILogger logger)
        {
            _logger = logger;
        }
        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
                throw;
            }
        }
    }
}
