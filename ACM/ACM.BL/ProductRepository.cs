using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    // repository design pattern 
    public class ProductRepository
    {
        // Retrieve one product
        public Product Retrieve(int productId)
        {
            // create the instance of the product class and pass in the requested id
            Product product = new Product(productId);

            // code that retrieves that definded product
            // hard coded values to return a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Birght Yellow Mini Sunflowers";
                product.ProductPrice = 15.96M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Object: {product.ToString()}");
            return product;
        }

        // save the current product 
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        // call an insert stored procedure
                    }
                    else
                    {
                        // call an update stored procedure
                    }
                }
                else
                {
                    success = false;    
                }
            }    
            return success;
        }

    }
}
