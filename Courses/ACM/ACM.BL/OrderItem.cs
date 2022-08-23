using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }


        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int ProductID { get; set; }
        public int OrderItemId { get; set; }

        public bool Validate()
        {
            Product product = new Product();
            var isValid = true;

            if (ProductID <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }


        public OrderItem Retrive(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

    }
}
