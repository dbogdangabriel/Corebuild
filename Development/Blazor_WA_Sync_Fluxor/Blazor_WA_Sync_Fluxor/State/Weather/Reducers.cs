using Blazor_WA_Sync_Fluxor.Model;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.State.Weather
{
    public static class Reducers
    {
        [ReducerMethod]
        public static WeatherDataState ReduceWeatherDataAction(WeatherDataState state, WeatherDataAction _) =>
            new(true, null, state.CurrentWeathers, null);

        [ReducerMethod]
        public static WeatherDataState ReduceWeatherDataSuccessAction(WeatherDataState state, WeatherDataSuccessAction action) =>
            new (false, null, state.CurrentWeathers, action.Forecasts);

        [ReducerMethod]
        public static WeatherDataState ReduceWeatherhDataErrorAction(WeatherDataState state, WeatherDataErrorAction action) =>
            new(false, action.Error, state.CurrentWeathers, null);

        [ReducerMethod]
        public static AddWeatherAction ReduceAddWeatherDataAction(WeatherDataState state, CreateWeatherAction _) =>
            new CreateWeatherAction(true, null, state.CurrentWeathers, state.CurrentWeather);


    }
}