using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.State;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.CreateWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Reducers
{
    public static class CreateWeatherActionsReducer
    {

        [ReducerMethod]
        public static WeatherState ReduceCreateWeatherAction(WeatherState state, CreateWeatherAction action) =>
         new WeatherState(true, null, state.Forecasts, state.Forecast);

        [ReducerMethod]
        public static WeatherState ReduceCreateWeatherSuccessAction(WeatherState state, CreateWeatherSuccesAction action)
        {
            // get weather list or initialize if we dont have one
            var currentForecasts = state.Forecasts is null ?
                new List<WeatherForecast>() :
                state.Forecasts.ToList();
            // add newly created forecast to our list and sort with Id
            currentForecasts.Add(action.Weather);
            currentForecasts = currentForecasts
                .OrderBy(w => w.WeatherId)
                .ToList();
            return new WeatherState(false, null, currentForecasts, state.Forecast);

        }

        [ReducerMethod]
        public static WeatherState ReduceCreateWeatherFailureAction(WeatherState state, CreateWeatherFailureAction action) =>
            new WeatherState(false, action.ErrorMessage, state.Forecasts, state.Forecast); // need to implement errorMessage
    }
}
