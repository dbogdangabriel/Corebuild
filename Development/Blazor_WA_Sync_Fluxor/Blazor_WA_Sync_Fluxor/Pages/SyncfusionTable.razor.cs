using Blazor_WA_Sync_Fluxor.Model;
using Blazor_WA_Sync_Fluxor.Store.State;
using Blazor_WA_Sync_Fluxor.Store.WeatherUseCase.Actions.LoadWeather;
using Fluxor;
using Microsoft.AspNetCore.Components;
using System.Xml;


namespace Blazor_WA_Sync_Fluxor.Pages
{
    public partial class SyncfusionTable
    {
        protected override void OnInitialized()
        {
            if (Weather.Value.Forecasts is null)
            {
                Facade.LoadWeather();
            }
            base.OnInitialized();
        }
/*
        [Inject]
        private IState<WeatherState> WeatherState { get; set; } = null!;
        [Inject]
        private IDispatcher? Dispatcher { get; set; }


        protected override void OnInitialized()
        {

            base.OnInitialized();
            Dispatcher?.Dispatch(new LoadWeatherAction()); //this triggers Fluxor to go get the state
        }*/
    }
}
