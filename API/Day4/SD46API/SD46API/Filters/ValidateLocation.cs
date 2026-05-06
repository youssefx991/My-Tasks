using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SD46API.Models;
using System.Text.RegularExpressions;

namespace SD46API.Filters
{
    public class ValidateLocation : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Befor Action Exection");
            Department d = context.ActionArguments["dept"] as Department;
            if (d != null)
            {
                var regex = new Regex("^(UK|USA)$");
                if (!regex.IsMatch(d.Location)) 
                {
                    context.ModelState.AddModelError("Location", "Loction not Covered");
                    context.Result = new BadRequestObjectResult(context.ModelState);

                }
            }

            
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("After Action Exection");
        }
    }
}
