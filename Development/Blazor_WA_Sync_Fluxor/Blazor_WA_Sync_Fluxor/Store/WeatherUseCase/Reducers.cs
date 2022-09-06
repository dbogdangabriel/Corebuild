using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.CreateWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase
{
    public static class Reducers
    {
        [ReducerMethod]
        public static WeatherState ReduceFetchDataAction(WeatherState state, FetchDataAction action) =>
            new(isLoading: true, forecasts: null);

        [ReducerMethod]
        public static WeatherState ReduceFetchDataResultAction(WeatherState state, FetchDataResultAction action) =>
            new(isLoading: false, forecasts: action.Forecasts);


        [ReducerMethod]
        public static WeatherState ReduceCreateWeatherAction(WeatherState state, CreateWeatherAction action) =>
         new WeatherState(isLoading: true, forecasts: null);

        [ReducerMethod]
        public static WeatherState ReduceCreateWeatherSuccessAction(WeatherState state, CreateWeatherSuccesAction action)
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
        public static WeatherState ReduceCreateWeatherFailureAction(WeatherState state, CreateWeatherFailureAction action) =>
            new WeatherState(isLoading: true, forecasts: null); // need to implement errorMessage

        /*        [ReducerMethod]
                public static WeatherState ReduceFetchAddAction(
                        WeatherState state, FetchDataAddAction action) =>
                        new WeatherState(
                        isLoading: false,
                        forecasts: action.Forecasts);*/
    }
}
