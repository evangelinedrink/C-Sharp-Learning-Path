﻿// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.ConsoleApp.Brokers.Storages;
using Example.ConsoleApp.Models.Samples;

namespace Example.ConsoleApp.Services.Foundations.Samples
{
    public class SampleService : ISampleService
    {
        private readonly IStorageBroker storageBroker;

        public SampleService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;      

        public Sample AddSample(Sample sample) =>
            throw new NotImplementedException();
    }
}
