using System.Diagnostics;

namespace Day1.Middlewares
{
    public class LoggingMiddleware
    {
        RequestDelegate Next { get; }
        ILogger<LoggingMiddleware> Logger { get; }

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            Next = next;
            Logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Logger.LogInformation($"Request Path: {context.Request.Path}, Request Method: {context.Request.Method}");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            await Next(context);
            sw.Stop();
            var statusCode = context.Response.StatusCode;
            var elapsedMs = sw.ElapsedMilliseconds;
            Logger.LogInformation($"Response Status Code: {statusCode}, Elapsed Time: {elapsedMs} ms");
        }
    }
}