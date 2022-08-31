namespace BlazorSyncfusion.Models.Orders.Dtos
{
    public class OrderDto
    {
        /*        public int? OrderID { get; set; }
                public string CustomerID { get; set; }
                public DateTime? OrderDate { get; set; }
                public double? Freight { get; set; }
                public string ShipCountry { get; set; }
                public bool Verified { get; set; }
        */
        public int Id { get; set; }

        public string? Title { get; set; }

        public bool Completed { get; set; }

        public int UserId { get; set; }
    }
}
