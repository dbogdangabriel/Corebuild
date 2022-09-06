using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Reducers
{
    public static class LoadWeatherActionsReducer
    {
        [ReducerMethod]
        public static WeatherState ReduceLoadWeatherAction(WeatherState state, LoadWeatherAction action) =>
          new(isLoading: true, forecasts: null);

        [ReducerMethod]
        public static WeatherState ReduceLoadWeatherSuccessAction(WeatherState state, LoadWeatherSuccessAction action) =>
            new(isLoading: false, forecasts: action.Forecasts);

    }
}
