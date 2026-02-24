using Microsoft.AspNetCore.Mvc;

namespace MyFirstCI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    [HttpGet("WeatherForecast")]
    [Produces("application/json")]
    public WeatherForcast[] Get()
    {
        var forcast = Enumerable.Range(1, 5).Select(index =>
            new WeatherForcast(
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55))
        ).ToArray();

        return forcast;
    }
}

public record WeatherForcast(DateOnly Date, int TemperatureC)
{
    public int TemperatureK => TemperatureC - 273;
}