using BlazorSyncfusion.Store.Features.Orders.Action.LoadOrders;
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
    }
}
