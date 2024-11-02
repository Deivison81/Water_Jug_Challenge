using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Jug_Challenge.Application.Exception;
using Water_Jug_Challenge.Application.Features.CapacityX;
using Water_Jug_Challenge.Domain;
using Xunit;

namespace Water_Jug_Challenge.Application.UnitTest.FeacturesTest.CapacityXTest
{
    public class CapacityXHandlerTest
    {
        [Fact]
        public void LlenarTest() 
        {
            //Arrange
            JugsX datos = new JugsX{x = 5,};
            var mockche = new Mock<IMemoryCache>();
            var cacheEntry = Mock.Of<ICacheEntry>();
            mockche.Setup(p=> p.CreateEntry(It.IsAny<object>())).Returns(cacheEntry);
            CapacityXHandler handler = new CapacityXHandler(mockche.Object);
            
            //Act
            var result = handler.Llenar(datos).Result;

            //Assert
           
           Assert.NotNull(result);
           //Assert.IsType<int>(result);
           Assert.Equivalent(datos, result);
        }
        
        public void VaciarTest() 
        {
            //Arrange
            JugsX datos = new JugsX{ x = 2};
            var mockche = new Mock<IMemoryCache>();
            var cacheEntry = Mock.Of<ICacheEntry>();
            mockche.Setup(p => p.CreateEntry(It.IsAny<object>())).Returns(cacheEntry);

            CapacityXHandler handler = new CapacityXHandler(mockche.Object);


            //Act
            var result = handler.Vaciar(datos).Result;

            //Assert
            Assert.NotNull(result);
            //Assert.IsType<int>(result);
            Assert.Equivalent(datos, result);
        }
    }
}
