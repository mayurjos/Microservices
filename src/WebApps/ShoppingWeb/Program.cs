using Common.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;

namespace ShoppingWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseCommonLogger()
                //.UseSerilog(SeriLogger.Configure)
                //
                //.UseSerilog((context, config) =>
                //{
                //    config
                //        .Enrich.FromLogContext()
                //        .Enrich.WithMachineName()
                //        .WriteTo.Console()
                //        .WriteTo.Elasticsearch(
                //            new ElasticsearchSinkOptions(new Uri(context.Configuration["ElasticConfiguration:Uri"]))
                //            {
                //                IndexFormat = $"applogs-{context.HostingEnvironment.ApplicationName?.ToLower().Replace(".", "-")}-{context.HostingEnvironment.EnvironmentName?.ToLower().Replace(".", "-")}-{DateTime.UtcNow:yyyy-MM}",
                //                AutoRegisterTemplate = true,
                //                NumberOfShards = 2,
                //                NumberOfReplicas = 2
                //            }
                //            ).Enrich.WithProperty("Environment", context.HostingEnvironment.EnvironmentName)
                //            .ReadFrom.Configuration(context.Configuration);

                        
                //})
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


    }
}
