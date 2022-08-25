using FluxorWithBlazor.Models;
using static FluxorWithBlazor.Pages.FetchData;

namespace FluxorWithBlazor.State
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
