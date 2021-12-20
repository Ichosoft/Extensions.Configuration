﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Ichsoft.Configuration.Extensions;

namespace MSTest
{
    /// <summary>
    /// Contains variables scoped to the Configuration.Extensions.MSTest assembly. 
    /// </summary>
    class MSTest
    {
        public static readonly ILogger Logger = LoggerFactory
            .Create(builder => builder
                .AddConsole()
                .SetMinimumLevel(LogLevel.Debug))
                .CreateLogger<MSTest>();
    }
}
