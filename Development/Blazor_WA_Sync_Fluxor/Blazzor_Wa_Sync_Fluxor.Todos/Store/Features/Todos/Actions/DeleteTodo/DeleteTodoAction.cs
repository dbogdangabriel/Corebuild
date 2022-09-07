namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.DeleteTodo
{
    public class DeleteTodoAction
    {
        public DeleteTodoAction(int id) =>
            Id = id;

        public int Id { get; }
    }
}
