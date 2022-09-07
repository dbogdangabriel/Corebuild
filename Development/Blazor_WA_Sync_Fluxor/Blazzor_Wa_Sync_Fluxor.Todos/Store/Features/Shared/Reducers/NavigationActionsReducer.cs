using Blazzor_Wa_Sync_Fluxor.Todos.Store.State;
using Fluxor;
using Fluxor.Blazor.Web.Middlewares.Routing;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Shared.Reducers
{
    public static class NavigationActionsReducer
    {
        [ReducerMethod]
        public static TodosState ReduceNavigationAction(TodosState state, GoAction _) =>
            new TodosState(state.IsLoading, null, state.CurrentTodos, state.CurrentTodo);
    }
}
