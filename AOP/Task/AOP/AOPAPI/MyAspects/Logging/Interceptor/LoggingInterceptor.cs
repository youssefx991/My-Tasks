using Castle.DynamicProxy;
using AOPAPI.MyAspects.Logging.Utilities;
using System.Diagnostics;

namespace AOPAPI.MyAspects.Logging.Interceptor
{
    public class LoggingInterceptor : IInterceptor
    {
        private readonly IApplicationLogger _logger;

        public LoggingInterceptor(IApplicationLogger logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            var methodName =
                invocation.Method.DeclaringType?.Name +
                "." +
                invocation.Method.Name;

            var stopwatch = Stopwatch.StartNew();

            try
            {
                _logger.LogMethodEntry(
                    methodName,
                    invocation.Arguments);

                invocation.Proceed();

                stopwatch.Stop();

                _logger.LogMethodExit(
                    methodName,
                    invocation.ReturnValue,
                    stopwatch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                stopwatch.Stop();

                _logger.LogMethodException(
                    methodName,
                    ex,
                    stopwatch.ElapsedMilliseconds);

                throw;
            }
        }
    }
}