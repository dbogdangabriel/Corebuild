using BlazorSyncfusion.Models.Orders.Dtos;
using BlazorSyncfusion.Store.Features.Orders.Actions.CreateOrder;
using BlazorSyncfusion.Store.State;
using Fluxor;

namespace BlazorSyncfusion.Store.Features.Orders.Reducers
{
    public static class CreateOrderActionsReducer
    {
        [ReducerMethod]
        public static OrdersState ReduceCreateOrderAction(OrdersState state, CreateOrderAction _) =>
            new OrdersState(true, null, state.CurrentOrders, state.CurrentOrder);
        [ReducerMethod]
        public static OrdersState ReduceCreateOrdersSuccessAction(OrdersState state, CreateOrderSuccessAction action)
        {
            // Grab a reference to the current order list, or initialize one if we do not currently have any laoded
            var currentOrders = state.CurrentOrders is null ?
                new List<OrderDto>() :
                state.CurrentOrders.ToList();

            // Add the newly created order to our list and sort by ID
            currentOrders.Add(action.Order);
            currentOrders = currentOrders
                .OrderBy(t => t.Id)
                .ToList();
            return new OrdersState(false, null, currentOrders, state.CurrentOrder);
        }

        [ReducerMethod]
        public static OrdersState ReduceCreateOrderFailureAction(OrdersState state, CreateOrderFailureAction action) =>
            new OrdersState(false, action.ErrorMessage, state.CurrentOrders, state.CurrentOrder);
    }
}
