namespace BankOrganization
{
    using System;
    using System.Collections.Generic;

    public abstract class Customer
    {
        private string name;
        private string id;
        private string customerNum;
        
        public Customer(string custName, string custID, string customerNumber)
        {
            this.Name = custName;
            this.ID = custID;
            this.CustomerNum = customerNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name of the customer can't be null.");
                }
                this.name = value;
            }
        }

        protected string ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value.Length < 10 || value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("The customer ID is not in the right format.");
                }
                this.id = value;
            }
        }

        public string CustomerNum
        {
            get
            {
                return this.customerNum;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The customer number can't be null.");
                }
                this.customerNum = value;
            }
        }

        public override string ToString()
        {
            return this.Name + " " + this.ID + " " + this.CustomerNum;
        }
    }
}
