using Blazor_WA_Sync_Fluxor.Store.State;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Reducers
{
    public static class LoadWeatherActionsReducer
    {
        [ReducerMethod]
        public static WeatherState ReduceLoadWeatherAction(WeatherState state, LoadWeatherAction action) =>
           new WeatherState(true, null, null, state.Forecast);

        [ReducerMethod]
        public static WeatherState ReduceLoadWeatherSuccessAction(WeatherState state, LoadWeatherSuccessAction action) =>
          new WeatherState(false, null, action.Forecasts, state.Forecast);

        [ReducerMethod]
        public static WeatherState ReduceLoadWeatherFailureAction(WeatherState state, LoadWeatherFailureAction action) =>
           new WeatherState(false, action.ErrorMessage, null, state.Forecast); // need to implement errorMessage

    }
}
