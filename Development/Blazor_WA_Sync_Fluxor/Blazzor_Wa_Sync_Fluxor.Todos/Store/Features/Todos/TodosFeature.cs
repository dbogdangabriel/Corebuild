using Blazzor_Wa_Sync_Fluxor.Todos.Store.State;
using Fluxor;

namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos
{
    public class TodosFeature : Feature<TodosState>
    {
        public override string GetName() => "Todos";

        protected override TodosState GetInitialState() =>
            new TodosState(true, null, null, null);
    }
}
