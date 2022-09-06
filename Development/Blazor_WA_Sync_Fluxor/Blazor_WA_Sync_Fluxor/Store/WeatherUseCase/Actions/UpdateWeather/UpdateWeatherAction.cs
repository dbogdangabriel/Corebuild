using Blazor_WA_Sync_Fluxor.Model;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.UpdateWeather
{
    public class UpdateWeatherAction
    {
        public UpdateWeatherAction(int weatherId, CreateOrUpdateWeather weather) =>
            (WeatherId, Weather) = (weatherId, weather);
        public CreateOrUpdateWeather Weather { get; }
        public int WeatherId { get; }
    }
}