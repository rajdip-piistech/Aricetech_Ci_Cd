using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using WebApplication1;
using WebApplication1.Controllers;
using Xunit;
namespace TestProject1;

public class ApiTests
{
    [Fact]
    public void Get_Returns_OkObjectResult_With_WeatherForecastArray()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<WeatherForecastController>>();
        var controller = new WeatherForecastController(mockLogger.Object);

        // Act
        var result = controller.Get();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result); 
        Assert.IsType<WeatherForecast[]>(okResult.Value); 
    }

}
