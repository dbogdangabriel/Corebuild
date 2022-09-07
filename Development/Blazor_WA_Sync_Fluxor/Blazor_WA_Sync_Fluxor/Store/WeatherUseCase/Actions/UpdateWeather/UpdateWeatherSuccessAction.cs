using Blazor_WA_Sync_Fluxor.Model;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.UpdateWeather
{
    public class UpdateWeatherSuccessAction
    {
        public UpdateWeatherSuccessAction(WeatherForecast weather) =>
            Weather = weather;
        public WeatherForecast Weather { get; }
    }
}