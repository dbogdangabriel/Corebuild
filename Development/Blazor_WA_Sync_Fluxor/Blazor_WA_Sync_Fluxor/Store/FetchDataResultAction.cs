using Blazor_WA_Sync_Fluxor.Model;

namespace Blazor_WA_Sync_Fluxor.Store
{
    public class FetchDataResultAction
    {
        public IEnumerable<WeatherForecast> Forecasts { get; }

        public FetchDataResultAction(IEnumerable<WeatherForecast> forecasts)
        {
            Forecasts = forecasts;
        }
    }
}
