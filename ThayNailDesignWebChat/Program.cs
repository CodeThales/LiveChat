using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using ThayNailDesign.Data;

namespace ThayNailDesign
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = CreateHostBuilder(args).Build();
            SeedDatabase.Initialize(app);
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
