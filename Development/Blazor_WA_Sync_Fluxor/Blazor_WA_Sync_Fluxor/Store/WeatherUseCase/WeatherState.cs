using Blazor_WA_Sync_Fluxor.Model;
using Fluxor;


namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase
{
    [FeatureState]
    public class WeatherState
    {
        public bool IsLoading { get; }
        public IEnumerable<WeatherForecast> Forecasts { get; }

        private WeatherState() { }
        public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
        {
            IsLoading = isLoading;
            Forecasts = forecasts ?? Array.Empty<WeatherForecast>();
        }
    }
}
