namespace BankOrganization
{
    using System;

    public class Individual : Customer
    {
        public Individual(string custName, string custID, string customerNumber) 
            :base(custName, custID, customerNumber)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.GetType().Name;
        }
    }
}
