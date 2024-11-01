using Microsoft.Extensions.Caching.Memory;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Jug_Challenge.Application.Features.VolumenZ;
using Water_Jug_Challenge.Domain;
using Xunit;

namespace Water_Jug_Challenge.Application.UnitTest.FeacturesTest.VolumenZTest
{
    public class VolumenZHandlerTest
    {
        [Fact]
        public void LlenarTest()
        {
            //Arrange
            JugsZ datos = new JugsZ{z = 12,};
            var mockche = new Mock<IMemoryCache>();
            var cacheEntry = Mock.Of<ICacheEntry>();
            mockche.Setup(p => p.CreateEntry(It.IsAny<object>())).Returns(cacheEntry);
            VolumenZHandler handler = new VolumenZHandler(mockche.Object);


            //Act
            var result = handler.Llenar(datos).Result;

            //Assert
            Assert.NotNull(result);
            //Assert.IsType<int>(result);
            Assert.Equivalent(datos, result);
        }
    }
}
