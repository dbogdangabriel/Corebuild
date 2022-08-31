using BlazorSyncfusion.Store.Features.Shared.Actions;

namespace BlazorSyncfusion.Store.Features.Orders.Actions.LoadOrders
{
    public class LoadOrdersFailureAction : FailureAction
    {
        public LoadOrdersFailureAction(string errorMessage)
              : base(errorMessage)
        {

        }
    }
}
