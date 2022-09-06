

using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase;
using Blazor_WA_Sync_Fluxor.Store;
using Fluxor;
using Microsoft.AspNetCore.Components;
using static Blazor_WA_Sync_Fluxor.Pages.Index;
using System.Xml;


namespace Blazor_WA_Sync_Fluxor.Pages
{
    public partial class SyncfusionTable
    {

        [Inject]
        private IState<WeatherState> WeatherState { get; set; } = null!;
        [Inject]
        private IDispatcher? Dispatcher { get; set; }

 
        protected override void OnInitialized()
        {

            base.OnInitialized();
            Dispatcher?.Dispatch(new FetchDataAction()); //this triggers Fluxor to go get the state
        }
    }
}
