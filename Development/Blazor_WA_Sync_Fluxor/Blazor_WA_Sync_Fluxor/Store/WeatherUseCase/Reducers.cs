using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase
{
    public static class Reducers
    {
        [ReducerMethod(typeof(FetchDataAction))]
        public static WeatherState ReduceFetchDataAction(WeatherState state) =>
          new WeatherState(
            isLoading: true,
            forecasts: null);

        [ReducerMethod]
        public static WeatherState ReduceFetchDataResultAction(
                WeatherState state, FetchDataAddAction action) =>
                new WeatherState(
                isLoading: false,
                forecasts: action.Forecasts);

/*        [ReducerMethod]
        public static WeatherState ReduceFetchAddAction(
                WeatherState state, FetchDataAddAction action) =>
                new WeatherState(
                isLoading: false,
                forecasts: action.Forecasts);*/
    }
}
