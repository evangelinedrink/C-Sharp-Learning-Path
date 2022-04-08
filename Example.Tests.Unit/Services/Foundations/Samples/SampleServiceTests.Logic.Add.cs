// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Example.ConsoleApp.Models.Samples;
using FluentAssertions;
using Moq;
using Xunit;

namespace Example.Tests.Unit.Services.Foundations.Samples
{
    public partial class SampleServiceTests
    {
        [Fact]
        public void ShouldAddSample()
        {
            //given
            Sample randomSample = CreateRandomSample();
            Sample inputSample = randomSample;
            Sample persistedSample = inputSample; //This is the sample that was saved in the database by the Storage Broker
            Sample expectedSample = persistedSample; //Whatever that is saved (in this case it is persistedSample) should be the expected returned value from the database

            this.storageBrokerMock.Setup(broker =>
                broker.InsertSample(inputSample))
                    .Returns(persistedSample);

            //when
            Sample actualSample = this.sampleService.AddSample(inputSample); //This code means that once the inputSample has been saved to the database, return this saved value as the actualSample variable

            //then
            actualSample.Should().BeEquivalentTo(expectedSample); //Whatever is being returned back (actualSample) from the database should be the same value as what was saved (the expectedSample

            this.storageBrokerMock.Verify(broker =>
                broker.InsertSample(inputSample),
                    Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
