using Blazor_WA_Sync_Fluxor.Model;
using Fluxor;
using System.Net.Http.Json;

namespace Blazor_WA_Sync_Fluxor.State.Weather
{
    public class Effects
    {

        private readonly HttpClient _httpClient;

        public Effects(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [EffectMethod]
        public async Task HandleAsync(WeatherDataAction action, IDispatcher dispatcher)
        {
            try
            {
                var forecasts = await _httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
                dispatcher.Dispatch(new WeatherDataSuccessAction(forecasts ??= Array.Empty<WeatherForecast>()));
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new WeatherDataErrorAction(ex.Message));
            }
        }
    }
}