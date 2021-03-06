﻿using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.Bath.Console.Standard;
using R5T.Richmond;


namespace R5T.Bath.Examples
{
    class ConsoleStandardStartup : StartupBase
    {
        public ConsoleStandardStartup(ILogger<ConsoleStandardStartup> logger)
            : base(logger)
        {
        }

        protected override void ConfigureServicesBody(IServiceCollection services)
        {
            services.AddConsoleHumanOutput();
        }
    }
}
