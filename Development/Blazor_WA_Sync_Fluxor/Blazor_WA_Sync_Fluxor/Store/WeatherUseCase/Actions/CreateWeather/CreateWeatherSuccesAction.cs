using Blazor_WA_Sync_Fluxor.Model;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.CreateWeather
{
    public class CreateWeatherSuccesAction
    {
        public CreateWeatherSuccesAction(WeatherForecast weather) =>
            Weather = weather;
        public WeatherForecast Weather { get; }
    }
}