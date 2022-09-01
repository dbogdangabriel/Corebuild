using Fluxor;
using static FluxorWithBlazor.Pages.FetchData;
using System.Net.Http.Json;
using FluxorWithBlazor.Models;

namespace FluxorWithBlazor.State.Weather
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
            if (forecasts is not null)
            {
                dispatcher.Dispatch(new FetchDataResultAction(forecasts: forecasts!));
            }
        }
    }
}
