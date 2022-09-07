using Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.UpdateTodo;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Effects.UpdateTodoEffect
{
    public class UpdateTodoSuccessEffect : Effect<UpdateTodoSuccessAction>
    {
        private readonly ILogger<UpdateTodoSuccessEffect> _logger;
        private readonly NavigationManager _navigation;

        public UpdateTodoSuccessEffect(ILogger<UpdateTodoSuccessEffect> logger, NavigationManager navigation) =>
            (_logger, _navigation) = (logger, navigation);

        public override Task HandleAsync(UpdateTodoSuccessAction action, IDispatcher dispatcher)
        {
            _logger.LogInformation("Updated todo successfully, navigating back to todo listing...");
            _navigation.NavigateTo("todos");

            return Task.CompletedTask;
        }
    }
}
