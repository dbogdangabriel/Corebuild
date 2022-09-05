

using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase;
using Blazor_WA_Sync_Fluxor.Store;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Blazor_WA_Sync_Fluxor.Pages
{
    public partial class SyncfusionTable
    {
        public static List<WeatherForecast> Forecasts { get; set; }
        [Inject]
        private IState<WeatherState> WeatherState { get; set; }
        [Inject]
        private IDispatcher Dispatcher { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Dispatcher.Dispatch(new FetchDataAction());
        }
    }
}
