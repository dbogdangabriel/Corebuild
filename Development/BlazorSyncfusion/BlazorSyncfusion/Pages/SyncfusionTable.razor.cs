using BlazorSyncfusion.Models;
using Syncfusion.Blazor.Grids;
using System.Dynamic;

namespace BlazorSyncfusion.Pages
{
    public partial class SyncfusionTable
    {
        public List<string> ToolbarItems = new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" };
        public List<Order>? Orders { get; set; }
        protected override void OnInitialized()
        {
            Orders = Enumerable.Range(1, 75).Select(x => new Order()
            {
                OrderID = 1000 + x,
                CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })[new Random().Next(5)],
                Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x,
                OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)],
                ShipCountry = (new string[] { "USA", "UK" })[new Random().Next(2)],
                Verified = (new bool[] { true, false })[new Random().Next(2)],

            }).ToList();
        }
    }
}
