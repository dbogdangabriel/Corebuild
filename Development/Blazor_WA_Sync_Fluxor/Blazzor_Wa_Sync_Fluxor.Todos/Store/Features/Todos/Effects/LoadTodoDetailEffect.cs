using Blazzor_Wa_Sync_Fluxor.Todos.Models.Todos.Dtos;
using Blazzor_Wa_Sync_Fluxor.Todos.Services;
using Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.LoadTodoDetail;
using Fluxor;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Effects
{
    public class LoadTodoDetailEffect : Effect<LoadTodoDetailAction>
    {
        private readonly ILogger<LoadTodoDetailEffect> _logger;
        private readonly JsonPlaceholderApiService _apiService;

        public LoadTodoDetailEffect(ILogger<LoadTodoDetailEffect> logger, JsonPlaceholderApiService httpClient) =>
            (_logger, _apiService) = (logger, httpClient);

        public override async Task HandleAsync(LoadTodoDetailAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation($"Loading todo {action.Id}...");
                var todoResponse = await _apiService.GetAsync<TodoDto>($"todos/{action.Id}");

                _logger.LogInformation($"Todo {action.Id} loaded successfully!");
                dispatcher.Dispatch(new LoadTodoDetailSuccessAction(todoResponse));
            }
            catch (Exception e)
            {
                _logger.LogError($"Error loading todo {action.Id}, reason: {e.Message}");
                dispatcher.Dispatch(new LoadTodoDetailFailureAction(e.Message));
            }

        }
    }
}
