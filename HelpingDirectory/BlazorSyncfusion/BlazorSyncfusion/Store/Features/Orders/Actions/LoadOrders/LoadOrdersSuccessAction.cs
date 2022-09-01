using BlazorSyncfusion.Models.Orders.Dtos;

namespace BlazorSyncfusion.Store.Features.Orders.Actions.LoadOrders
{
    public class LoadOrdersSuccessAction
    {
        public LoadOrdersSuccessAction(IEnumerable<OrderDto> orders) =>
            Orders = orders;

        public IEnumerable<OrderDto> Orders { get; }
    }
}
