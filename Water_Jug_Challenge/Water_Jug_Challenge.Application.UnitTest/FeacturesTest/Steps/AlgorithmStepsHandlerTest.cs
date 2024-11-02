using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Water_Jug_Challenge.Application.Features.Steps;
using Water_Jug_Challenge.Application.Models;
using Xunit;

namespace Water_Jug_Challenge.Application.UnitTest.FeacturesTest.Steps
{
    public class AlgorithmStepsHandlerTest
    {
        [Fact]
        public void solutions() 
        {
            //Arrange
            var steps = new Stepsby(1)
            {
                ValueSteps = 1,
                Arist = new List<Stepsby> 
                { 
                    new Stepsby(2){ValueSteps = 2},
                    new Stepsby(3){ValueSteps = 3}
                }
                
            };
            //Act
          
            //Assert


        }

    }
}
