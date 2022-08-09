using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int orderId)
        {
            ProductId = orderId;
        }

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces(); 
            }

            set { _productName = value; }
        }
        public string Log() =>
          $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; } // ? folosit sa avem o diferenta intre pretul 0 si value null

        public override string ToString() => ProductName;
        public override bool Validate()
        {
            Product product = new Product();
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (ProductPrice == null) isValid = false;
            return isValid;
        }



    }
    
}
