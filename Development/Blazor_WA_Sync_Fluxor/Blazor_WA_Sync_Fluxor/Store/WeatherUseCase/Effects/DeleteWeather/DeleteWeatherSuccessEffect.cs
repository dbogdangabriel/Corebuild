using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.DeleteWeather;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Effects.DeleteWeather
{
    public class DeleteWeatherSuccessEffect : Effect<DeleteWeatherSuccessAction>
    {
        private readonly ILogger<DeleteWeatherSuccessEffect> _logger;
        private readonly NavigationManager _navigation;

        public DeleteWeatherSuccessEffect(ILogger<DeleteWeatherSuccessEffect> logger, NavigationManager navigation) =>
            (_logger, _navigation) = (logger, navigation);

        public override Task HandleAsync(DeleteWeatherSuccessAction action, IDispatcher dispatcher)
        {
            _logger.LogInformation("Deleted forecast successfully, navigating back to forecast listing...");
            _navigation.NavigateTo("weather");

            return Task.CompletedTask;
        }
    }
}
