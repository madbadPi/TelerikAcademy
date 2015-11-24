namespace BankOrganization
{
    using System;

    public class Company : Customer
    {
        private string compName;

        public Company(string custName, string custID, string customerNumber, string companyName) 
            :base(custName, custID, customerNumber)
        {
            this.CompName =  companyName;
        }

        public string CompName
        {
            get
            {
                return this.compName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name of the company can't be null.");
                }
                this.compName = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.GetType().Name + " " + this.CompName; 
        }
            
    }
}
