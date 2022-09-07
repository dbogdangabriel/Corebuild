using Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Shared.Actions;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.UpdateTodo
{
    public class UpdateTodoFailureAction : FailureAction
    {
        public UpdateTodoFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}
