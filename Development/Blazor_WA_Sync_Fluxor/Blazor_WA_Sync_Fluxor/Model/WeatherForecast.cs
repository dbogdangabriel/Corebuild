namespace Blazor_WA_Sync_Fluxor.Model
{
    public class WeatherForecast
    {
        public int WeatherId { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}