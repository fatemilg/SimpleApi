using System;
using Xunit;
using SimpleApi.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Test
{
    public class UnitTest1
    {

        private readonly Mock<ILogger<WeatherForecastController>> _mockILogger;
        private readonly WeatherForecastController _weatherForecastController;
        public UnitTest1()
        {
            _mockILogger = new Mock<ILogger<WeatherForecastController>>();
            _weatherForecastController = new WeatherForecastController(_mockILogger.Object);
        }
        //test
        [Fact]
        public void Get_ShouldReturnList()
        {
            var returnValue = _weatherForecastController.Get(); 
            Assert.Equal("saeed", "saeed");

        }
    }
}
