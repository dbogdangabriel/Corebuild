using Blazzor_Wa_Sync_Fluxor.Todos.Models.Todos.Dtos;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.UpdateTodo
{
    public class UpdateTodoSuccessAction
    {
        public UpdateTodoSuccessAction(TodoDto todo) =>
            Todo = todo;

        public TodoDto Todo { get; }
    }
}
