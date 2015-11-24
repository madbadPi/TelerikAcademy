namespace BankOrganization
{
    using System;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer accountCusomer, decimal accountBalance, decimal accountInterestRate)
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

        public decimal WithDrawMoney(decimal amountOfMoney)
        {
            if (amountOfMoney <= 0 || (this.Balance - amountOfMoney) < 0)
            {
                throw new ArgumentOutOfRangeException("The amount of money that you withdraw can't be less or equal to zero or the balance is insufficient");
            }
            return base.Balance -= amountOfMoney;
        }

        public override decimal CalcInterestForPeriod(int numOfMonths)
        {
            //Deposit accounts have no interest 
            //if their balance is positive and less than 1000.
            if (base.Balance > 0 && base.Balance < 1000)
            {
                return 0;
            }
            return base.CalcInterestForPeriod(numOfMonths);
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.GetType().Name;
        }
    }
}
