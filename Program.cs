using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Colorful;
using System.Drawing;

namespace NitsyS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Api server running on port 5000", Color.Red);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logger => logger.ClearProviders())
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());

    }
}