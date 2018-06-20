using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {


        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }
        public static int instanceCount { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }



        public Boolean Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}
