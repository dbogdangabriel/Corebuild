namespace BlazorSyncfusion.Models
{
    public class OrderDto
    {
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }
        public string ShipCountry { get; set; }
        public bool Verified { get; set; }

    }
}
