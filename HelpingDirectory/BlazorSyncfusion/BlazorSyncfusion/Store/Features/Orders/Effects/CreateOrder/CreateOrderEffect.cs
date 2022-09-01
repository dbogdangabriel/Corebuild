using BlazorSyncfusion.Models.Orders.Dtos;
using BlazorSyncfusion.Services;
using BlazorSyncfusion.Store.Features.Orders.Actions.CreateOrder;
using Fluxor;
using System.Net.Http.Json;

namespace BlazorSyncfusion.Store.Features.Orders.Effects.CreateOrder
{
    public class CreateOrderEffect : Effect<CreateOrderAction>
    {
        private readonly ILogger<CreateOrderEffect> _logger;
        private readonly JsonPlaceholderApiService _apiService;

        public CreateOrderEffect(ILogger<CreateOrderEffect> logger, JsonPlaceholderApiService httpClient) =>
            (_logger, _apiService) = (logger, httpClient);

        public override async Task HandleAsync(CreateOrderAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation($"Creating order {action.Order}...");
                var createResponse = await _apiService.PostAsync("orders", action.Order);
                if (!createResponse.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error creating orders: {createResponse.ReasonPhrase}");
                }
                _logger.LogInformation("Order created successfully!");
                var createOrder = await createResponse.Content.ReadFromJsonAsync<OrderDto>();
                dispatcher.Dispatch(new CreateOrderSuccessAction(createOrder));
            }
            catch (Exception e)
            {
                _logger.LogError($"Could not create todo, reason: {e.Message}");
                dispatcher.Dispatch(new CreateOrderFailureAction(e.Message));
            }
        }
    }
}
