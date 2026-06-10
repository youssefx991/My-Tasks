using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using ITI46.TrackingApp.Server.Protos;
using System.Text;
using static ITI46.TrackingApp.Server.Protos.TrackingService;

namespace ITI46.TrackingApp.Client
{
    public class Worker(ILogger<Worker> logger, int deviceId) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7238");

            var client = new TrackingServiceClient(channel);

            var keepAliveTask = Task.Run(async () =>
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    var stream = client.KeepAlive();
                    await stream.RequestStream.WriteAsync(new PulseMessage
                    {
                        DeviceId = deviceId,
                        Timestamp = Timestamp.FromDateTime(DateTime.UtcNow)
                    });

                    await Task.Delay(3000, stoppingToken);
                }
            });

            var notificationTask = Task.Run(async () =>
            {
                var stream = client.SubscribeNotifications(new SubscriptionRequest { DeviceId = deviceId });

                while (await stream.ResponseStream.MoveNext(stoppingToken))
                {
                    var msg = stream.ResponseStream.Current;

                    logger.LogInformation("Received Notification: {message} at {timestamp}", msg.Message, msg.Timestamp);
                }
            });

            var random = new Random();

            while (!stoppingToken.IsCancellationRequested)
            {

                try
                {
                    var msg = new TrackingMessage
                    {
                        DeviceId = deviceId,
                        Speed = random.Next(0, 200),
                        Location = new Location
                        {
                            Long = random.NextDouble(),
                            Lat = random.NextDouble()
                        },
                        Timestamp = Timestamp.FromDateTime(DateTime.UtcNow),
                    };

                    msg.Sensors.Add(new Sensor { Name = "SeatBelt", Value = 1 });

                    var tokenValue = "admin:P@ssw0rd";
                    var bytes = Encoding.UTF8.GetBytes(tokenValue);
                    var encodedToken = Convert.ToBase64String(bytes);

                    var headers = new Metadata
                    {
                        { "Authorization", $"Basic {encodedToken}" }
                    };

                    var response = await client.SendMessageAsync(msg, headers);

                    logger.LogInformation("Received Response: {response}", response.Success);
                }
                catch(RpcException ex)
                {
                    logger.LogError(ex, "Error sending tracking message");
                }

                await Task.Delay(1000, stoppingToken);
            }

            await Task.WhenAll(keepAliveTask, notificationTask);
        }
    }
}
