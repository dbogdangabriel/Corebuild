using Blazzor_Wa_Sync_Fluxor.Todos.Models.Todos.Dtos;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.CreateTodo
{
    public class CreateTodoSuccessAction
    {
        public CreateTodoSuccessAction(TodoDto todo) =>
            Todo = todo;

        public TodoDto Todo { get; }
    }
}
