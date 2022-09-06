using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.CreateWeather;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase
{
    public static class Reducers
    {
        [ReducerMethod]
        public static WeatherState ReduceLoadWeatherAction(WeatherState state, LoadWeatherAction action) =>
            new(isLoading: true, forecasts: null);

        [ReducerMethod]
        public static WeatherState ReduceLoadWeatherSuccessAction(WeatherState state, LoadWeatherSuccessAction action) =>
            new(isLoading: false, forecasts: action.Forecasts);


        [ReducerMethod]
        public static WeatherState ReduceCreateWeatherAction(WeatherState state, UpdateWeatherAction action) =>
         new WeatherState(isLoading: true, forecasts: null);

        [ReducerMethod]
        public static WeatherState ReduceCreateWeatherSuccessAction(WeatherState state, UpdateWeatherSuccesAction action)
        {
            // get weather list or initialize if we dont have one
            var currentWeather = state.Forecasts is null?
                new List<WeatherForecast>() :
                state.Forecasts.ToList();
            // add newly created forecast to our list and sort with Id
            currentWeather.Add(action.Weather);
            currentWeather = currentWeather
                .OrderBy(w => w.WeatherId)
                .ToList();
            return new WeatherState(isLoading: false, forecasts: currentWeather);

        }

        [ReducerMethod]
        public static WeatherState ReduceCreateWeatherFailureAction(WeatherState state, UpdateWeatherFailureAction action) =>
            new WeatherState(isLoading: true, forecasts: null); // need to implement errorMessage

    }
}
