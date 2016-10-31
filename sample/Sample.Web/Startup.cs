using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banian.Infrastructure.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Sample.Web
{
    public class Startup : BanianStartup
    {
        public Startup(IHostingEnvironment env, ILoggerFactory loggerFactory)
            : base(env, loggerFactory)
        {
        }
    }
}
