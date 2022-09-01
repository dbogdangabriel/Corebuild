using BlazorSyncfusion.Models.Orders.Dtos;

namespace BlazorSyncfusion.Store.Features.Orders.Actions.CreateOrder
{
    public class CreateOrderSuccessAction
    {
        public CreateOrderSuccessAction(OrderDto order) =>
            Order = order;

        public OrderDto Order { get;}
    }
}
