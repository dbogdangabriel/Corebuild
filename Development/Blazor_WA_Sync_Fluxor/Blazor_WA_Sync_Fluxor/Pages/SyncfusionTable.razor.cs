

using Blazor_WA_Sync_Fluxor.State.Weather;

namespace Blazor_WA_Sync_Fluxor.Pages
{
    public partial class SyncfusionTable
    {
        public List<string> ToolbarItems = new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" };
        protected override void OnInitialized()
        {
            base.OnInitialized();
            dispatcher.Dispatch(new WeatherDataAction());
        }
    }
}
