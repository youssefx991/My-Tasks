using System.Diagnostics;

namespace SD46API.Middlwares
{
    public class LoggingMiddleware
    {
        RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        { 
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine($"Request Path => {context.Request.Path} , Method => {context.Request.Method}");
        
           await _next(context);
            sw.Stop();  
            Console.WriteLine($"Response => {context.Response.StatusCode} , Time Taken => {sw.ElapsedMilliseconds} ms");
        }
    }
}
