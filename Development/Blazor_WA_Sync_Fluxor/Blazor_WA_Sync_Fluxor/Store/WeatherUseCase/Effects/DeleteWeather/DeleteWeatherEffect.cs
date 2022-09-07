using Blazor_WA_Sync_Fluxor.Services;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.DeleteWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Effects.DeleteWeather
{
    public class DeleteWeatherEffect : Effect<DeleteWeatherAction>
    {
        private readonly ILogger<DeleteWeatherEffect> _logger;
        private readonly JsonPlaceholderApiService _apiService;

        public DeleteWeatherEffect(ILogger<DeleteWeatherEffect> logger, JsonPlaceholderApiService apiService) =>
            (_logger, _apiService) = (logger, apiService);

        public override async Task HandleAsync(DeleteWeatherAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation($"Deleting forecast {action.WeatherId}...");
                var deleteResponse = await _apiService.DeleteAsync($"forecasts/{action.WeatherId}");

                if (!deleteResponse.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error deleting forecast: {deleteResponse.ReasonPhrase}");
                }

                _logger.LogInformation($"forecast deleted successfully!");
                dispatcher.Dispatch(new DeleteWeatherSuccessAction(action.WeatherId));
            }
            catch (Exception e)
            {
                _logger.LogError($"Could not create forecast, reason: {e.Message}");
                dispatcher.Dispatch(new DeleteWeatherFailureAction(e.Message));
            }
        }
    }
}
