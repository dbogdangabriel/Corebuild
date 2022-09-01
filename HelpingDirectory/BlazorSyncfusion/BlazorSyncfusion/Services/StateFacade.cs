using BlazorSyncfusion.Models.Orders.Dtos;
using BlazorSyncfusion.Store.Features.Orders.Actions.CreateOrder;
using BlazorSyncfusion.Store.Features.Orders.Actions.LoadOrders;
using Fluxor;

namespace BlazorSyncfusion.Services
{
    public class StateFacade
    {
        private readonly ILogger<StateFacade> _logger;
        private readonly IDispatcher _dispatcher;

        public StateFacade(ILogger<StateFacade> logger, IDispatcher dispatcher) =>
            (_logger, _dispatcher) = (logger, dispatcher);

        public void LoadOrders()
        {
            _logger.LogInformation("Issuing action to load orders...");
            _dispatcher.Dispatch(new LoadOrdersAction());
        }

        public void CreateOrder(string title, bool completed, int userId)
        {
            // Construct our validated todo
            var orderDto = new CreateOrUpdateOrderDto(title, completed, userId);

            _logger.LogInformation($"Issuing action to create todo [{title}] for user [{userId}]");
            _dispatcher.Dispatch(new CreateOrderAction(orderDto));
        }

    }
}
