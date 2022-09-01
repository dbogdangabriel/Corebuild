using Blazor_WA_Sync_Fluxor.Model;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.State.Weather
{
    public class Feature : Feature<WeatherDataState>
    {
        public override string GetName() => "Weather";
        protected override WeatherDataState GetInitialState() =>
            new WeatherDataState(true, null, null, null);
    }
}
