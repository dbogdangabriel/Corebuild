using Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Shared.Actions;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.DeleteTodo
{
    public class DeleteTodoFailureAction : FailureAction
    {
        public DeleteTodoFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}
