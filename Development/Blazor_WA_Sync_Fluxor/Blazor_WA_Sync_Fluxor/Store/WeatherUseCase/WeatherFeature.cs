using Blazor_WA_Sync_Fluxor.Store.State;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase
{
    public class WeatherFeature : Feature<WeatherState>
    {
        public override string GetName() => "Forecasts";

        protected override WeatherState GetInitialState() =>
            new WeatherState(true, null, null, null);
    }
}
