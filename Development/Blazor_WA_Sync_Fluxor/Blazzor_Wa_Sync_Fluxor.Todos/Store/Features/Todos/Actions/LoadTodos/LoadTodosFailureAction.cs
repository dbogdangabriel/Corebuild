using Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Shared.Actions;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.LoadTodos
{
    public class LoadTodosFailureAction : FailureAction
    {
        public LoadTodosFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}
