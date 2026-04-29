using Microsoft.AspNetCore.Mvc.Filters;

namespace Day1.Filters
{
    public class ResultFilter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("After Result");

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("Before Result");
            Console.Read();

        }
    }
}
