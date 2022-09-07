using Blazzor_Wa_Sync_Fluxor.Todos.Models.Todos.Dtos;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.LoadTodos
{
    public class LoadTodosSuccessAction
    {
        public LoadTodosSuccessAction(IEnumerable<TodoDto> todos) =>
            Todos = todos;

        public IEnumerable<TodoDto> Todos { get; }
    }
}
