using Blazor_WA_Sync_Fluxor.Model;

namespace Blazor_WA_Sync_Fluxor.State.Weather
{

    public record WeatherDataAction();
    public record WeatherDataSuccessAction(WeatherForecast[] Forecasts);
    public record WeatherDataErrorAction(string Error);

    public record AddWeatherAction(WeatherForecast forecast);
    public record AddWeatherSuccessAction(WeatherForecast forecast);
    public record AddWeatherDataErrorAction(string Error);

    public record DeleteWeatherAction(WeatherForecast forecast);
    public record DeleteWeatherSuccessAction(WeatherForecast forecast);
    public record DeleteWeatherDataErrorAction(string Error);


}