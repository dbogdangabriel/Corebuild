using Blazor_WA_Sync_Fluxor.Store.Shared.Action;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.CreateWeather
{
    public class CreateWeatherFailureAction : FailureAction
    {
        public CreateWeatherFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}