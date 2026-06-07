using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using ITI46.TrackingApp.Server.Protos;
using static ITI46.TrackingApp.Server.Protos.TrackingService;

namespace ITI46.TrackingApp.Server.Services
{
    public class LocationTrackingService : TrackingServiceBase
    {
        private readonly ILogger<LocationTrackingService> logger;

        public LocationTrackingService(ILogger<LocationTrackingService> logger) => this.logger = logger;

        public override Task<TrackingResponse> SendMessage(TrackingMessage request, ServerCallContext context)
        {
            logger.LogInformation("New Message Received. DeviceId: {DeviceId} Location: ({Lat}, {Long}) Speed: {Speed}",
                request.DeviceId,
                request.Location.Lat,
                request.Location.Long,
                request.Speed);

            return Task.FromResult(new TrackingResponse { Success = true });
        }

        public override async Task<Empty> KeepAlive(IAsyncStreamReader<PulseMessage> requestStream, ServerCallContext context)
        {
            while(await requestStream.MoveNext())
            {
               var msg =  requestStream.Current;

               logger.LogInformation("New Pulse Received. DeviceId: {DeviceId} Timestamp: {Timestamp}",
                msg.DeviceId,
                msg.Timestamp);
            }

            return new Empty();
        }

        public override async Task SubscribeNotifications(SubscriptionRequest request, IServerStreamWriter<NotificationMessage> responseStream, ServerCallContext context)
        {
            while (!context.CancellationToken.IsCancellationRequested)
            {
                await responseStream.WriteAsync(new NotificationMessage
                {
                    Message = $"Notification for Device {request.DeviceId} at {DateTime.UtcNow}",
                    Timestamp = Timestamp.FromDateTime(DateTime.UtcNow)
                });

                await Task.Delay(5000); 
            }
        }
    }
}
