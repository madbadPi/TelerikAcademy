namespace BankOrganization
{
    using System;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer accountCusomer, decimal accountBalance, decimal accountInterestRate)
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
            //Mortgage accounts have ½ interest for the first 
            //12 months for companies and 
            //no interest for the first 6 months for individuals
            if (base.Customer is Individual)
            {
                return base.CalcInterestForPeriod(numOfMonths - 6);
            }

            if (base.Customer is Company )
            {
                if (numOfMonths - 12 <= 0)
                {
                    base.InterestRate /= 2;
                    return base.CalcInterestForPeriod(numOfMonths);
                }

                else //if (numOfMonths > 12)
                {
                    return (base.Balance * (base.InterestRate / 200) * 12) + (base.Balance * (base.InterestRate / 100) * (numOfMonths - 12));
                }
            }
            return base.CalcInterestForPeriod(numOfMonths); 
        }
        public override string ToString()
        {
            return base.ToString() + " " + this.GetType().Name;
        }
    }
}
