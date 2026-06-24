using AOPAPI.Aspects.Logging.Utilities;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using PostSharp.Serialization;

namespace AOPAPI.Aspects.Logging.PostSharp
{
    [PSerializable]
    [MulticastAttributeUsage(MulticastTargets.Method, TargetMemberAttributes = MulticastAttributes.Public | MulticastAttributes.Instance)]
    public class LoggingAspect : OnMethodBoundaryAspect
    {
        private static readonly ILogger Logger = new Log4NetLogger();

        public override void OnEntry(MethodExecutionArgs args)
        {
            Logger.LogDebug("On Entry");
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Logger.LogDebug("On Success");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Logger.LogDebug("On Exit");
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Logger.LogError(args.Exception);
            args.FlowBehavior = FlowBehavior.RethrowException;
        }
      
        
    }
}
