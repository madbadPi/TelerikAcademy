namespace BankOrganization
{
    using System;

    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer accountCusomer, decimal accountBalance, decimal accountInterestRate)
        {
            this.Customer = accountCusomer;
            this.Balance = accountBalance;
            this.InterestRate = accountInterestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid data for customer");
                }
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The balance can't be negative.");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The interest rate can't be negative or zero");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal CalcInterestForPeriod(int numOfMonths)
        {
            if (numOfMonths <= 0)
            {
                return 0;
            }
            return this.Balance * (this.InterestRate / 100) * numOfMonths;
        }

        public override string ToString()
        {
            return "Account holder :\n" + Customer.ToString() + "\nAccount balance:" + this.Balance + "\nInterest Rate:" + this.InterestRate + "%";
        }
    }
}
