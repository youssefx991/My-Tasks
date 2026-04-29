using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Day1.Filters
{
    public class ExceptionHandleFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            ContentResult result = new ContentResult();
            result.Content = $"Error in Action: {context.ActionDescriptor.DisplayName}, Exception Filter: {context.Exception.Message}";
            context.Result = result;
        }
    }
}
