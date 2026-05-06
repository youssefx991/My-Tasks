namespace SD46API.Middlwares
{
    public static class UseLoggingExtensions
    {
        public static IApplicationBuilder UseLogging(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LoggingMiddleware>();
        }
    }
        
}
