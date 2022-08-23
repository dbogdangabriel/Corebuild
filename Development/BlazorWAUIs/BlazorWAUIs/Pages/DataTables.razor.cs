namespace BlazorWAUIs.Pages
{
    public partial class DataTables
    {
        public List<Order> Orders { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Orders = Enumerable.Range(0, 10).Select(x => new Order()
            {
                OrderID = 1 + x,
                CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })[new Random().Next(5)],
                Freight = 2.1 * x,
                OrderDate = DateTime.Now.AddDays(-x),
            }).ToList();
        }
    }
}
