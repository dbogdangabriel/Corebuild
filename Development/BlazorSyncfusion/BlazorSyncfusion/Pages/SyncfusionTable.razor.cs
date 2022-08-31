namespace BlazorSyncfusion.Pages
{
    public partial class SyncfusionTable
    {
        public List<string> ToolbarItems = new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" };
        protected override void OnInitialized()
        {
            // Issue the load todos command, if no current todos have been loaded
            if (OrdersState.Value.CurrentOrders is null)
            {
                Facade.LoadOrders();
            }

            base.OnInitialized();
        }
    }
}
