namespace Day1.Middlewares
{
    public class ExceptionHandleMiddleware
    {
        RequestDelegate Next { get; }

        public ExceptionHandleMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await Next(context);
            }
            catch (Exception ex)
            {
                //context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync($"Error in Request Path: {context.Request.Path}, Exception Middleware: {ex.Message}");
            }
        }
    }
}
