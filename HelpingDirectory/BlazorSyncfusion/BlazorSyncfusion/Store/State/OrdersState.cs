using BlazorSyncfusion.Models.Orders.Dtos;

namespace BlazorSyncfusion.Store.State
{
    public class OrdersState : RootState
    {
        public OrdersState(bool isLoading, string? currentErrorMessage, IEnumerable<OrderDto>? currentOrders, OrderDto? currentOrder) 
            : base(isLoading, currentErrorMessage)
        {
            CurrentOrders = currentOrders;
            CurrentOrder = currentOrder;
        }

        public IEnumerable<OrderDto>? CurrentOrders { get; }

        public OrderDto? CurrentOrder { get; }
    }
}
