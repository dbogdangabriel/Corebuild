using Blazor_WA_Sync_Fluxor.Store.Shared.Action;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.DeleteWeather
{
    public class DeleteWeatherFailureAction : FailureAction
    {
        public DeleteWeatherFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}