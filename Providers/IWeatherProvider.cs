using System.Collections.Generic;
using vuejscore.Models;

namespace vuejscore.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
