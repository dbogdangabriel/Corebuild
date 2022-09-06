using Fluxor;
using System.Net.Http.Json;
using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase
{
    public class Effects
    {
        private readonly HttpClient Http;

        public Effects(HttpClient http)
        {
            Http = http;
        }

        [EffectMethod]
        public async Task HandleFetchDataAction(LoadWeatherAction action, IDispatcher dispatcher)
        {
            var forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            dispatcher.Dispatch(new LoadWeatherSuccessAction(forecasts: forecasts!));
        }
    }
}