using BlazorSyncfusion.Models.Orders.Dtos;

namespace BlazorSyncfusion.Store.Features.Orders.Actions.CreateOrder
{
    public class CreateOrderAction
    {
        public CreateOrderAction(CreateOrUpdateOrderDto order) =>
            Order = order;
        public CreateOrUpdateOrderDto Order { get;}
    }
}
