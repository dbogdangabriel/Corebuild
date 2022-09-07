using Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Shared.Actions;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.CreateTodo
{
    public class CreateTodoFailureAction : FailureAction
    {
        public CreateTodoFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}
