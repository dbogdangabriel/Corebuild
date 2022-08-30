using Fluxor;
using BlazorSyncfusion.Store.State;

namespace BlazorSyncfusion.Store.Features.Orders
{
    public class OrdersFeature : Feature<OrdersState>
    {
        public override string GetName() => "Orders";

        protected override OrdersState GetInitialState() =>
            new OrdersState(true, null, null, null);
    }
}
