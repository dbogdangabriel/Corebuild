using Blazor_WA_Sync_Fluxor.Store.Shared.Action;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.UpdateWeather
{
    public class UpdateWeatherFailureAction : FailureAction
    {
        public UpdateWeatherFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}