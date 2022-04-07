
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.ConsoleApp.Models.Samples;
using Xunit;

namespace Example.Tests.Unit.Services.Foundations.Samples
{
    public partial class SampleServiceTests
    {
        [Fact]
        public void ShouldAddSample()
        {
            //given
            Sample inputSample = CreateRandomSample();
            
            //when
            this.sampleService.addSample(inputSample);

            //then
        }
    }
}
