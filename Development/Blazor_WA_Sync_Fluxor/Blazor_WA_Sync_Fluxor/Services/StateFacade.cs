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
        public void LoadWeather()
        {
            _logger.LogInformation("Issuing action to load todos...");
            _dispatcher.Dispatch(new LoadWeatherAction());
        }


        public void CreateWeather(DateTime date,int temperatureC, string title)
        {
            // Construct our validated todo
            var weather = new CreateOrUpdateWeather(date, temperatureC, title);

            _logger.LogInformation($"Issuing action to create todo [{title}] for user");
            _dispatcher.Dispatch(new CreateWeatherAction(weather));
        }

        public void UpdateWeather(int weatherId, DateTime date, int temperatureC, string title)
        {
            // Construct our validated todo
            var weather = new CreateOrUpdateWeather(date, temperatureC, title);

            _logger.LogInformation($"Issuing action to update todo {weatherId}");
            _dispatcher.Dispatch(new UpdateWeatherAction(weatherId, weather));
        }

        public void DeleteTodo(int id)
        {
            _logger.LogInformation($"Issuing action to delete todo {id}");
            _dispatcher.Dispatch(new DeleteWeatherAction(id));
        }
    }
}
