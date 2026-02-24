using MyFirstCI.Api.Controllers;

namespace MyFirstCI.Api.Test;

public class WeatherControllerTests
{
    [Fact]
    public void Get_ReturnFiveValue()
    {
        // Arrange
        var controller = new WeatherController();
        // Act
        var result = controller.Get();
        // Assert
        Assert.Equal(5, result.Length);
    }

    [Fact]
    public void Get_ReturnAllFutureValues()
    {
        // Arrange
        var controller = new WeatherController();
        // Act
        var result = controller.Get();
        // Assert
        foreach (var weatherForcast in result)
        {
            Assert.True(weatherForcast.Date > DateOnly.FromDateTime(DateTime.Now));
        }
        
    }
}
