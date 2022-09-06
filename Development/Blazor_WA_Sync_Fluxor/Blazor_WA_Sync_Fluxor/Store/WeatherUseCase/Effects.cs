using Fluxor;
using System.Net.Http.Json;
using Blazor_WA_Sync_Fluxor.Model;

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
        public async Task HandleFetchDataAction(FetchDataAction action, IDispatcher dispatcher)
        {
            var forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            dispatcher.Dispatch(new FetchDataResultAction(forecasts: forecasts!));
        }
    }
}