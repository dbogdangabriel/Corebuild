using Blazzor_Wa_Sync_Fluxor.Todos.Models.Todos.Dtos;
using Blazzor_Wa_Sync_Fluxor.Todos.Services;
using Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.LoadTodos;
using Fluxor;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Effects
{
    public class LoadTodosEffect : Effect<LoadTodosAction>
    {
        private readonly ILogger<LoadTodosEffect> _logger;
        private readonly JsonPlaceholderApiService _apiService;

        public LoadTodosEffect(ILogger<LoadTodosEffect> logger, JsonPlaceholderApiService httpClient) =>
            (_logger, _apiService) = (logger, httpClient);

        public override async Task HandleAsync(LoadTodosAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation("Loading todos...");
                var todosResponse = await _apiService.GetAsync<IEnumerable<TodoDto>>("todos");

                _logger.LogInformation("Todos loaded successfully!");
                dispatcher.Dispatch(new LoadTodosSuccessAction(todosResponse.Take(5)));
            }
            catch (Exception e)
            {
                _logger.LogError($"Error loading todos, reason: {e.Message}");
                dispatcher.Dispatch(new LoadTodosFailureAction(e.Message));
            }

        }
    }
}
