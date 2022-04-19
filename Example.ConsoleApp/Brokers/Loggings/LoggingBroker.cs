// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Example.ConsoleApp.Brokers.Loggings
{
    internal class LoggingBroker : ILoggingBroker
    {
        public ILogger logger { get; set; }

        public LoggingBroker(ILogger<LoggingBroker> logger) =>
            this.logger = logger;
        
        public void LogError(Exception exception) =>
             throw new NotImplementedException();
        
    }
}
