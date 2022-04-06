// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.ConsoleApp.Brokers.Storages;
using Example.ConsoleApp.Services.Foundations.Samples;
using Moq;

namespace Example.Tests.Unit.Services.Foundations.Samples
{
    internal class SampleServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly ISampleService sampleService;

        public SampleServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.sampleService = new SampleService(
                storageBroker: this.storageBrokerMock.Object);
        }
    }
}
