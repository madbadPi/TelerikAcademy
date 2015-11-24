namespace BankOrganization
{
    using System;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer accountCusomer, decimal accountBalance, decimal accountInterestRate)
            : base(accountCusomer, accountBalance, accountInterestRate)
        {
            
        }

        public decimal DepositeMoney(decimal amountOfMoney)
        {
            if (amountOfMoney <= 0)
            {
                throw new ArgumentOutOfRangeException("The amount of money that you deposit can't be less or equal to zero.");
            }
            return base.Balance += amountOfMoney;
        }

        public override decimal CalcInterestForPeriod(int numOfMonths)
        {
            //Loan accounts have no interest for the first 
            //3 months if are held by individuals and for the first 
            //2 months if are held by a company.

            if (base.Customer is Individual)
            {
                return base.CalcInterestForPeriod(numOfMonths - 3);
            }

            if (base.Customer is Company)
            {
                return base.CalcInterestForPeriod(numOfMonths - 2);
            }

            return base.CalcInterestForPeriod(numOfMonths);
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.GetType().Name;
        }
    }
}
