using Blazor_WA_Sync_Fluxor.Model;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather
{
    public class LoadWeatherSuccessAction
    {
        public IEnumerable<WeatherForecast> Forecasts { get; }

        public LoadWeatherSuccessAction(IEnumerable<WeatherForecast> forecasts)
        {
            Forecasts = forecasts;
        }
    }
}
