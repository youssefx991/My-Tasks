using AOPAPI.MyAspects.Logging.Utilities;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using PostSharp.Serialization;
using System.Diagnostics;

namespace AOPAPI.MyAspects.Logging.PostSharp
{
    [PSerializable]
    [MulticastAttributeUsage(
        MulticastTargets.Method,
        TargetMemberAttributes =
            MulticastAttributes.Public |
            MulticastAttributes.Instance)]
    public class LoggingAspect : OnMethodBoundaryAspect
    {
        private static readonly IApplicationLogger Logger =
            new Log4NetApplicationLogger();

        private long _startTime;

        public override void OnEntry(MethodExecutionArgs args)
        {
            try
            {
                _startTime = Stopwatch.GetTimestamp();

                var methodName =
                    args.Method.DeclaringType?.Name +
                    "." +
                    args.Method.Name;

                Logger.LogMethodEntry(
                    methodName,
                    args.Arguments.ToArray());
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            try
            {
                var executionTime =
                    GetElapsedMilliseconds(_startTime);

                var methodName =
                    args.Method.DeclaringType?.Name +
                    "." +
                    args.Method.Name;

                Logger.LogMethodExit(
                    methodName,
                    args.ReturnValue,
                    executionTime);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }

        public override void OnException(MethodExecutionArgs args)
        {
            try
            {
                var executionTime =
                    GetElapsedMilliseconds(_startTime);

                var methodName =
                    args.Method.DeclaringType?.Name +
                    "." +
                    args.Method.Name;

                Logger.LogMethodException(
                    methodName,
                    args.Exception,
                    executionTime);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }

            args.FlowBehavior = FlowBehavior.RethrowException;
        }

        private long GetElapsedMilliseconds(long startTimestamp)
        {
            var endTimestamp = Stopwatch.GetTimestamp();

            return (long)(
                (endTimestamp - startTimestamp)
                * 1000.0
                / Stopwatch.Frequency);
        }
    }
}