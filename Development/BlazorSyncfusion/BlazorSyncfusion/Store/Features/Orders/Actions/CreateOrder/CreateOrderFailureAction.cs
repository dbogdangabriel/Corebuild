using BlazorSyncfusion.Store.Features.Shared.Actions;

namespace BlazorSyncfusion.Store.Features.Orders.Actions.CreateOrder
{
    public class CreateOrderFailureAction : FailureAction
    {
        public CreateOrderFailureAction(string errorMessage)
            : base(errorMessage)
        {

        }
    }
}
