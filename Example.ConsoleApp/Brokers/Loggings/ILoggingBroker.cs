﻿// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.ConsoleApp.Brokers.Loggings
{
    internal interface ILoggingBroker
    {
        void LogError(Exception exception);
    }
}
