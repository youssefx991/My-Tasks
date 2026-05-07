namespace Day1.Middlewares
{
    public class ExceptionHandleMiddleware
    {
        RequestDelegate Next { get; }

        public ExceptionHandleMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await Next(context);
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsync($"Error in Request Path: {context.Request.Path}, Exception Middleware: {ex.Message}, Inner Exception: {ex.InnerException?.Message}");
            }
        }
    }
}
