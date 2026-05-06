using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SD46API.Filters
{
    public class HandleExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
           ContentResult res = new ContentResult();
            res.Content = $"Error Happend : {context.ActionDescriptor.DisplayName} , {context.Exception.Message}";
            context.Result = res ;
        }
    }
}
