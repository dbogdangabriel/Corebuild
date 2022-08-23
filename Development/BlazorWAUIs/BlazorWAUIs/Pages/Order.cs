namespace BlazorWAUIs.Pages
{
    public partial class DataTables
    {
        public class Order
        {
            public int? OrderID { get; set; }
            public string CustomerID { get; set; }
            public DateTime? OrderDate { get; set; }
            public double? Freight { get; set; }
        }
    }
}
