﻿using MyMiddleWebServer.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMiddleWebServer.WebHost
{
    public class Startup : IStartup
    {
        public void Configure(MiddlewareBuilder builder)
        {
            builder.Use<LoggerMiddleware>();
            builder.Use<MvcMiddleware>();
            builder.Use<StaticFileMiddleware>();
        }
    }
}
