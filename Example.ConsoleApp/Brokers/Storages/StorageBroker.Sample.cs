﻿// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Example.ConsoleApp.Models.Samples;

namespace Example.ConsoleApp.Brokers.Storages
{
    public partial class StorageBroker : IStorageBroker
    {
        List<Sample> Samples = new List<Sample>();
        public Sample InsertSample(Sample sample)
        {
            Samples.Add(sample);

            return sample;
        }
    }
}
