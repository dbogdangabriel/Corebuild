using BlazorSyncfusion.Store.Features.Shared.Actions;

namespace BlazorSyncfusion.Store.Features.Orders.Action.LoadOrders
{
    public class LoadOrdersFailureAction : FailureAction
    {
        public LoadOrdersFailureAction(string errorMessage)
              : base(errorMessage)
        {

        }
    }
}
