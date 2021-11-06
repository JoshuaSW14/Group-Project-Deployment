using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1_TeamMembershipSystem.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Azure.Identity;
using Lab1_TeamMembershipSystem.Models;

namespace Lab1_TeamMembershipSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();//.Run();

            var configuration = host.Services.GetService<IConfiguration>();
            //var hosting = host.Services.GetService<IWebHostEnvironment>();

            var secrets = configuration.GetSection("Secrets").Get<AppSecrets>();
            DbInitializer.appSecrets = secrets;

            using (var scope = host.Services.CreateScope())
            {
                DbInitializer.SeedUsersAndRoles(scope.ServiceProvider).Wait();
                host.Run();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
