using Fluxor;
using FluxorWithBlazor.Models;
using static FluxorWithBlazor.Pages.FetchData;

namespace FluxorWithBlazor.State.Weather
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
