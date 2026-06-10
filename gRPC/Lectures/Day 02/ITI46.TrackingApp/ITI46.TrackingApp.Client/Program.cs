namespace ITI46.TrackingApp.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DeviceId:");
            int deviceId = int.Parse(Console.ReadLine());

            var builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddHostedService<Worker>(svc =>
            {
                var logger = svc.GetRequiredService<ILogger<Worker>>();
                return new Worker(logger, deviceId);
            });

            var host = builder.Build();
            host.Run();
        }
    }
}
