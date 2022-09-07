using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Services;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Effects
{
    public class LoadWeatherEffect : Effect<LoadWeatherAction>
    {
        private readonly ILogger<LoadWeatherEffect> _logger;
        private readonly JsonPlaceholderApiService _apiService;

        public LoadWeatherEffect(ILogger<LoadWeatherEffect> logger, JsonPlaceholderApiService httpClient) =>
            (_logger, _apiService) = (logger, httpClient);

        public override async Task HandleAsync(LoadWeatherAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation("Loading weather...");
                var forecastsResponse = await _apiService.GetAsync<IEnumerable<WeatherForecast>>("Weather");

                _logger.LogInformation("Forecasts loaded successfully!");
                dispatcher.Dispatch(new LoadWeatherSuccessAction(forecastsResponse.Take(5)));
            }
            catch (Exception e)
            {
                _logger.LogError($"Error loading forecast, reason: {e.Message}");
                dispatcher.Dispatch(new LoadWeatherFailureAction(e.Message));
            }

        }
    }
}

/*        private readonly HttpClient Http;

        public Effects(HttpClient http)
        {
            Http = http;
        }

        [EffectMethod]
        public async Task HandleFetchDataAction(LoadWeatherAction action, IDispatcher dispatcher)
        {
            var forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            dispatcher.Dispatch(new LoadWeatherSuccessAction(forecasts: forecasts!));
        }*/