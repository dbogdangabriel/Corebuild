using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.CreateWeather;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.DeleteWeather;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.UpdateWeather;
using Fluxor;

namespace Blazor_WA_Sync_Fluxor.Services
{
    public class StateFacade
    {
        private readonly ILogger<StateFacade> _logger;
        private readonly IDispatcher _dispatcher;
        public StateFacade(ILogger<StateFacade> logger, IDispatcher dispatcher)
        {
            _logger = logger;
            _dispatcher = dispatcher;
        }

/*        public void LoadWeatherById(int id)
        {
            _logger.LogInformation($"Issuing action to load forecast {id}...");
            _dispatcher.Dispatch(new LoadWeatherDetailAction(id));
        }*/
        public void LoadWeather()
        {
            _logger.LogInformation("Issuing action to load forecats...");
            _dispatcher.Dispatch(new LoadWeatherAction());
        }


        public void CreateWeather(DateTime date,int temperatureC, string title)
        {
            // Construct our validated forecast
            var weather = new CreateOrUpdateWeather(date, temperatureC, title);

            _logger.LogInformation($"Issuing action to create forecats [{date}] with temperature [{temperatureC}]");
            _dispatcher.Dispatch(new CreateWeatherAction(weather));
        }

        public void UpdateWeather(int weatherId, DateTime date, int temperatureC, string title)
        {
            // Construct our validated forecast
            var weather = new CreateOrUpdateWeather(date, temperatureC, title);

            _logger.LogInformation($"Issuing action to update forecast {weatherId}");
            _dispatcher.Dispatch(new UpdateWeatherAction(weatherId, weather));
        }

        public void DeleteWeather(int id)
        {
            _logger.LogInformation($"Issuing action to delete forecast {id}");
            _dispatcher.Dispatch(new DeleteWeatherAction(id));
        }
    }
}
