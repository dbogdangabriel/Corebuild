using Blazor_WA_Sync_Fluxor.Model;
using Fluxor;

using System.Net.Http;
using System.Net.Http.Json;

namespace Blazor_WA_Sync_Fluxor.Store
{

    public class FetchDataAddAction
    {
        private readonly HttpClient _httpClient;
        public FetchDataAddAction(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IEnumerable<WeatherForecast> Forecasts { get; }

        public async Task FDResultAction(FetchDataAddAction action, IDispatcher dispatcher)
        {

           /* await Task.Delay(500); // just so we can see the "submitting" message
            var response = await _httpClient.PostAsJsonAsync("Feedback", action.WeatherForecast);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Succes");
            }
            else
            {
                Console.WriteLine("Fail");
            }*/
        }

    }
}
