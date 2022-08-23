using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{

    // repository design pattern 
    public class OrderRepository
    {
        // Retrieve one Order
        public Order Retrieve(int orderId)
        {
            // create the instance of the Order class and pass in the requested id
            Order order = new Order(orderId);

            // code that retrieves that definded Order
            // hard coded values to return a populated Order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                    new TimeSpan(7, 0, 0 ));  

            }
            return order;
        }

        // save the current Order 
        public bool Save(Order product)
        {
            return true;
        }

    }
}


