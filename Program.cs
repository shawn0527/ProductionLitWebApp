using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ProductionLiteWebApp.Models;

namespace ProductionLiteWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //User user = new User();
            //user.FirstName = "shawn";
            //Console.WriteLine(user.FirstName);
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(SetupConfiguration)
                .UseStartup<Startup>();

        private static void SetupConfiguration(WebHostBuilderContext context, IConfigurationBuilder configurationBuilder)
        {
            // Removing the default configuration options
            configurationBuilder.Sources.Clear();

            // Configuration source setup by order
            configurationBuilder.AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables();
        }
    }
}
