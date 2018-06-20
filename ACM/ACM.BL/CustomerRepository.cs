using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(1);

            if(customerId==1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
