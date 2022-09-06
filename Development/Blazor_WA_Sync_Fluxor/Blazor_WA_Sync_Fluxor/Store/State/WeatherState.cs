using Blazor_WA_Sync_Fluxor.Model;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.State
{
        public class WeatherState : RootState
    {
        public WeatherState(bool isLoading, string? currentErrorMessage, IEnumerable<WeatherForecast>? forecasts, WeatherForecast? forecast)
        : base(isLoading, currentErrorMessage)
        {
            Forecasts = forecasts;
            Forecast = forecast;
        }
        public IEnumerable<WeatherForecast>? Forecasts { get; }
        public WeatherForecast? Forecast { get; }
    }
}
