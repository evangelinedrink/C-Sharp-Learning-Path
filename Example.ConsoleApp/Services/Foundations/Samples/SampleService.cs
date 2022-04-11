// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

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
            //We are receiving the data, but we want to tamper the data
            //Whatever the user is passing in, we are going to override it, so it won't save
            //This test below was used to show how DeepClone is important for copying the data before it goes into the database
            //and then comparing the database data with the original data
            //sample.Text = "override";

            //I believe that the this. is used for classes to specify which class is going to be used
            //Insert is the keyword to add something in a Storage Broker.  Add is the keyword to add something in Foundation Services.
            this.storageBroker.InsertSample(sample); //We want to save the data of the sample by using the storageBroker
    }
}
