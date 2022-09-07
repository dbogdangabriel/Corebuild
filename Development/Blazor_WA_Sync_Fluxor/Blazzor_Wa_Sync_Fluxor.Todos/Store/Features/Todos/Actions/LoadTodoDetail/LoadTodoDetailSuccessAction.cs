using Blazzor_Wa_Sync_Fluxor.Todos.Models.Todos.Dtos;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.LoadTodoDetail
{
    public class LoadTodoDetailSuccessAction
    {
        public LoadTodoDetailSuccessAction(TodoDto todo) =>
            Todo = todo;

        public TodoDto Todo { get; }
    }
}
