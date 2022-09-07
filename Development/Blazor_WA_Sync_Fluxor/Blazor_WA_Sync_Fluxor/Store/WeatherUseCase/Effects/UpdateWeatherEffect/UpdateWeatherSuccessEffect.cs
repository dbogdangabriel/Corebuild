using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.UpdateWeather;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Effects.UpdateWeatherEffect
{
    public class UpdateWeatherSuccessEffect : Effect<UpdateWeatherSuccessAction>
    {
        private readonly ILogger<UpdateWeatherSuccessEffect> _logger;
        private readonly NavigationManager _navigation;

        public UpdateWeatherSuccessEffect(ILogger<UpdateWeatherSuccessEffect> logger, NavigationManager navigation) =>
            (_logger, _navigation) = (logger, navigation);

        public override Task HandleAsync(UpdateWeatherSuccessAction action, IDispatcher dispatcher)
        {
            _logger.LogInformation("Updated Weather successfully, navigating back to Weather listing...");
            _navigation.NavigateTo("Forecasts");

            return Task.CompletedTask;
        }
    }
}
