using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.State;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.UpdateWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Reducers
{
    public static class UpdateWeatherActionsReducer
    {
        [ReducerMethod]
        public static WeatherState ReduceUpdateWeatherAction(WeatherState state, UpdateWeatherAction action) =>
             new WeatherState(true, null, state.Forecasts, state.Forecast);
        [ReducerMethod]
        public static WeatherState ReduceUpdateWeatherSuccessAction(WeatherState state, UpdateWeatherSuccessAction action)
        {
            // check if the weather list is null, if not set the state with a new list containing the update
            if (state.Forecasts is null)
            {
                return new WeatherState(false, null, new List<WeatherForecast> { action.Weather}, state.Forecast);
            }

            //creating new list and update item
            var updateList = state.Forecasts
                .Where(w => w.WeatherId != action.Weather.WeatherId)
                .ToList();

            // add the new forecast and sort the list
            updateList.Add(action.Weather);
            updateList = updateList
                .OrderBy(w => w.WeatherId)
                .ToList();
            return new WeatherState(false, null, updateList, null);
        }

        [ReducerMethod]
        public static WeatherState ReduceUpdateWeatherFailureAction(WeatherState state, UpdateWeatherFailureAction action) =>
           new WeatherState(false, action.ErrorMessage, state.Forecasts, state.Forecast); // need to implement errorMessage
    }
}
