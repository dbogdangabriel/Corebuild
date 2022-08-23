using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        // Retrieve one address
        public Address Retrieve(int addressId)
        {
            // create the instance of the product class and pass in the requested id
            Address address = new Address(addressId);

            // code that retrieves that definded product
            // hard coded values to return a populated product
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag end";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerID(int customerId)
        {
            var addressList = new List<Address>(); 
            Address address = new Address(1);
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag end";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            };
            addressList.Add(address);
            address = new Address(2);
            {
                address.AddressType = 2;
                address.StreetLine1 = "Green Dragon";
                address.City = "Bywater";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "146";
            }
            addressList.Add(address);  
            return addressList;
        }
        // save the current product 
        public bool Save(Address address)
        {
            return true;
        }
    }
}
