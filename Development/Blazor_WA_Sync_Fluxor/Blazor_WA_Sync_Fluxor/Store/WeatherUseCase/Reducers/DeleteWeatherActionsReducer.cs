using Blazor_WA_Sync_Fluxor.Store.State;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.DeleteWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Reducers
{
    public static class DeleteWeatherActionsReducer
    {
        [ReducerMethod]
        public static WeatherState ReduceDeleteWeatherAction(WeatherState state, DeleteWeatherAction action) =>
             new WeatherState(true, null, state.Forecasts, state.Forecast);

        [ReducerMethod]
        public static WeatherState ReduceDeleteWeatherSuccessAction(WeatherState state, DeleteWeatherSuccessAction action)
        {
            // return the default state if there is no forecast found
            if(state.Forecasts is null)
            {
                return new WeatherState(true, null, null, state.Forecast);
            }

            // create a new list with all the forecast excluding the deleted id
            var updatedWeather = state.Forecasts.Where(w => w.WeatherId != action.WeatherId);

            return new WeatherState(true, null, updatedWeather, state.Forecast);
        }
        [ReducerMethod]
        public static WeatherState ReduceDeleteWeatherFailureAction(WeatherState state, DeleteWeatherFailureAction action) =>
             new WeatherState(false, action.ErrorMessage, state.Forecasts, state.Forecast); // need to implement errorMessage
    }
}
