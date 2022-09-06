namespace Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.DeleteWeather
{
    public class DeleteWeatherAction
    {
        public DeleteWeatherAction(int weatherId) =>
            WeatherId = weatherId;

        public int WeatherId { get; }
    }
}
