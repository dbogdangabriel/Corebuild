using BlazorSyncfusion.Models;

namespace BlazorSyncfusion.Store.Features.Orders.Action.LoadOrders
{
    public class LoadOrdersSuccessAction
    {
        public LoadOrdersSuccessAction(IEnumerable<OrderDto> orders) =>
            Orders = orders;

        public IEnumerable<OrderDto> Orders { get; }
    }
}
