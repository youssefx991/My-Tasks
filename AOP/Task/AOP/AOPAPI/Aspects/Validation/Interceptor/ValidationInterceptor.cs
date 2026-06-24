using Castle.DynamicProxy;

namespace AOPAPI.Aspects.Validation.Interceptor
{
    public class ValidationInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Validating input ...");
            invocation.Proceed();
        }
    }
}
