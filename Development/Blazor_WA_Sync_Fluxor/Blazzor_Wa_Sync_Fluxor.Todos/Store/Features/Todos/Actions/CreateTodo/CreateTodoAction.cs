using Blazzor_Wa_Sync_Fluxor.Todos.Models.Todos.Dtos;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.CreateTodo
{
    public class CreateTodoAction
    {
        public CreateTodoAction(CreateOrUpdateTodoDto todo) =>
            Todo = todo;

        public CreateOrUpdateTodoDto Todo { get; }
    }
}
