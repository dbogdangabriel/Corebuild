using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.Shared.Action;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather
{
    public class LoadWeatherFailureAction : FailureAction
    {
        public LoadWeatherFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}