using Blazzor_Wa_Sync_Fluxor.Todos.Models.Todos.Dtos;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.UpdateTodo
{
    public class UpdateTodoAction
    {
        public UpdateTodoAction(int id, CreateOrUpdateTodoDto todo) =>
            (Id, Todo) = (id, todo);

        public int Id { get; }

        public CreateOrUpdateTodoDto Todo { get; }
    }
}
