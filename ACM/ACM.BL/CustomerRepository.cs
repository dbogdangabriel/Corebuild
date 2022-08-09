using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    // repository design pattern 
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();   //enstablishing a colaborative relationship between customerrep and addresrep
        }
        public AddressRepository addressRepository { get; set; }
        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            // create the instance of the customer class and pass in the requested id
            Customer customer = new Customer(customerId); 

            // code that retrieves that definded customer
            // hard coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "saghasga@gmail.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerID(customerId).ToList();
            }
            return customer;
        }

        // save the current customer 
        public bool Save(Customer customer)
        {
            return true;
        }

    }
}
