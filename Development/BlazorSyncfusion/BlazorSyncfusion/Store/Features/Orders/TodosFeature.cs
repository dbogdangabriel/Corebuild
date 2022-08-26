using Fluxor;
using BlazorSyncfusion.Store.State;

namespace BlazorSyncfusion.Store.Features.Todos
{
    public class TodosFeature : Feature<OrdersState>
    {
        public override string GetName() => "Orders";

        protected override OrdersState GetInitialState() =>
            new OrdersState(true, null, null, null);
    }
}
