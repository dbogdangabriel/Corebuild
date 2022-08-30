using BlazorSyncfusion.Models;
using BlazorSyncfusion.Store.Features.Orders.Action.LoadOrders;
using Fluxor;
using System.Net.Http.Json;

namespace BlazorSyncfusion.Store.Features.Orders.Effects
{
    public class LoadOrdersEffect : Effect<LoadOrdersAction>
    {
        private readonly ILogger<LoadOrdersEffect> _logger;
        private readonly HttpClient _httpClient;

        public LoadOrdersEffect(ILogger<LoadOrdersEffect> logger, HttpClient httpClient) =>
            (_logger, _httpClient) = (logger, httpClient);

        public override async Task HandleAsync(LoadOrdersAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation("Loading orders...");

                // Add a little extra latency for dramatic effect...
                await Task.Delay(TimeSpan.FromMilliseconds(1000));
                var ordersResponse = await _httpClient.GetFromJsonAsync<IEnumerable<OrderDto>>("Orders");

                _logger.LogInformation("Orders loaded successfully!");
                dispatcher.Dispatch(new LoadOrdersSuccessAction(ordersResponse));
            }
            catch (Exception e)
            {
                _logger.LogError($"Error loading orders, reason: {e.Message}");
                dispatcher.Dispatch(new LoadOrdersFailureAction(e.Message));
            }

        }
    }
}
