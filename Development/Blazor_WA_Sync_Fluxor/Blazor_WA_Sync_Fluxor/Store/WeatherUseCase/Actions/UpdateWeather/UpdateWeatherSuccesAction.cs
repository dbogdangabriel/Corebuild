using Blazor_WA_Sync_Fluxor.Model;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.UpdateWeather
{
    public class UpdateWeatherSuccesAction
    {
        public UpdateWeatherSuccesAction(WeatherForecast weather) =>
            Weather = weather;
        public WeatherForecast Weather { get; }
    }
}