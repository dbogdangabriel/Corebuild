using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0) // cunstructor chaining, its calling the other cunstructor
        {

        }
        public Customer(int customerId)
        {
            // fara parametru default contructor, daca nu faci un constructor ai automat un constructor implicit
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; } // the relation between the customer class and address one
        // for a list a default is null, astfel trebuie sa-l adaugam in constructor pentru buna functionare
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public override string ToString() => FullName;
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName)) 
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            { return _lastName; }
            set
            { _lastName = value; }

        }

        /// <summary>
        /// Log the information
        /// </summary>
        /// <returns></returns>
        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
       

        // Validates the customer data
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;   
            return isValid; 
        }


    }
}