using BlazorSyncfusion.Store.Features.Orders.Action.LoadOrders;
using BlazorSyncfusion.Store.State;
using Fluxor;

namespace BlazorSyncfusion.Store.Features.Orders.Reducers
{
    public static class LoadOrdersActionsReducer
    {
        [ReducerMethod]
        public static OrdersState ReduceLoadTodosAction(OrdersState state, LoadOrdersAction _) =>
            new OrdersState(true, null, null, state.CurrentOrder);

        [ReducerMethod]
        public static OrdersState ReduceLoadTodosSuccessAction(OrdersState state, LoadOrdersSuccessAction action) =>
            new OrdersState(false, null, action.Orders, state.CurrentOrder);

        [ReducerMethod]
        public static OrdersState ReduceLoadTodosFailureAction(OrdersState state, LoadOrdersFailureAction action) =>
            new OrdersState(false, action.ErrorMessage, null, state.CurrentOrder);

    }
}
