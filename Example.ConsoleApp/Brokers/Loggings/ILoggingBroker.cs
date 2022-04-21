// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

namespace Example.ConsoleApp.Brokers.Loggings
{
    internal interface ILoggingBroker
    {
        void LogError(Exception exception);
    }
}
