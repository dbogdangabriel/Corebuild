using Syncfusion.Blazor.Grids.Internal;

namespace Blazor_WA_Sync_Fluxor.Model
{
    public class CreateOrUpdateWeather
    {
        public CreateOrUpdateWeather(DateTime date, int temperaturec, string? title) =>
            (Date, TemperatureC, Title) = (date, temperaturec, title);
        public DateTime Date { get;  }
        public int TemperatureC { get;  }
        public string? Title { get;  }
    }

}
