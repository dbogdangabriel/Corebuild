using Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Shared.Actions;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.LoadTodoDetail
{
    public class LoadTodoDetailFailureAction : FailureAction
    {
        public LoadTodoDetailFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}
