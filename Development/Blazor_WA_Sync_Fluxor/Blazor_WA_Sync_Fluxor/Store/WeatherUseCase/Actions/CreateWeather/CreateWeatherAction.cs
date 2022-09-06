using Blazor_WA_Sync_Fluxor.Model;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.CreateWeather
{
    public class UpdateWeatherAction
    {
        public UpdateWeatherAction(CreateOrUpdateWeather weather) =>
            Weather = weather;
        public CreateOrUpdateWeather Weather { get; }
    }
}