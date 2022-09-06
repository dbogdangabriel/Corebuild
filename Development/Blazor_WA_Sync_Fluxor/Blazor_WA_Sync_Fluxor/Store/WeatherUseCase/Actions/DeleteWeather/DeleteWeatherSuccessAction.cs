namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.DeleteWeather
{
    public class DeleteWeatherSuccessAction
    {
        public DeleteWeatherSuccessAction(int weatherId) =>
            WeatherId = weatherId;
        public int WeatherId { get; }
    }
}
