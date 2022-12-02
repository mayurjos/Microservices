using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logging
{
    public static class HostExtensions
    {
        public static IHostBuilder UseCommonLogger(this IHostBuilder builder)
        {
            builder.UseSerilog(SeriLogger.Configure);
            return builder;
        }
    }
}
