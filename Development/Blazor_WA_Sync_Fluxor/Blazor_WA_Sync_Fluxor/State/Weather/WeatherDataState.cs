using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.State;

namespace Blazor_WA_Sync_Fluxor.State.Weather
{
    public class WeatherDataState : RootState
    {
        public WeatherDataState(bool isLoading, string? currentErrorMessage,
        IEnumerable<WeatherForecast>? currentWeathers, WeatherForecast? currentWeather)
            : base(isLoading, currentErrorMessage)
        {
            CurrentWeathers = currentWeathers;
            CurrentWeather = currentWeather;
        }

        public IEnumerable<WeatherForecast>? CurrentWeathers { get; }

        public WeatherForecast? CurrentWeather { get; }
    }
}

