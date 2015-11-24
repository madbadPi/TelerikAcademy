namespace BankOrganization
{
    using System;
    using System.Collections.Generic;

    public class BankTest
    {
        static void Main()
        {
            //TODO: change DepositeMoney and WithDrawMoney methods - Don't repeat yourself

            Individual firstIndCustomer = new Individual("Ivo Ivanov", "8112065512", "C11221");
            Individual secondIndCustomer = new Individual("Ani Alexandrova", "7902065411", "C00001");
            Individual thirdIndCustomer = new Individual("Lena Alexieva", "7402065411", "C00002");
            Company firstCompCustomer = new Company("Ivan Michov", "7912015478", "A12122", "CEZ");
            Company secondCompCustomer = new Company("Ivan Michov", "7912015478", "A12123", "CEZ");
            Company thirdCompCustomer = new Company("Alex Alex", "8012015475", "A12124", "CEZ");

            //DepositAccount firstDepositAcc = new DepositAccount(firstIndCustomer, 0.00m, 0.2m);
            //DepositAccount secondDepositAcc = new DepositAccount(secondIndCustomer, 100000.00m, 0.2m);
            //DepositAccount thirdDepositAcc = new DepositAccount(thirdIndCustomer, 120.01m, 0.6m);
            //Console.WriteLine(firstDepositAcc.DepositeMoney(100));
            //Console.WriteLine(secondDepositAcc.DepositeMoney(10));
            //Console.WriteLine(secondDepositAcc.Balance);
            //Console.WriteLine(secondDepositAcc.WithDrawMoney(10));
            //Console.WriteLine(secondDepositAcc.Balance);

            //Console.WriteLine(firstDepositAcc.CalcInterestForPeriod(0));
            //Console.WriteLine(secondDepositAcc.CalcInterestForPeriod(12));
            //Console.WriteLine(thirdDepositAcc.CalcInterestForPeriod(24));
            
            LoanAccount firstLoanAcc = new LoanAccount(firstIndCustomer, 0.00m, 0.2m);
            LoanAccount secondLoanAcc = new LoanAccount(firstCompCustomer, 0.00m, 0.2m);
            LoanAccount thirdLoanAcc = new LoanAccount(secondIndCustomer, 100000.00m, 0.2m);
            LoanAccount fourthLoanAcc = new LoanAccount(secondCompCustomer, 100000.00m, 0.2m);

            //Console.WriteLine(firstLoanAcc.CalcInterestForPeriod(1));
            //Console.WriteLine(secondLoanAcc.CalcInterestForPeriod(1));
            //Console.WriteLine(thirdLoanAcc.CalcInterestForPeriod(24));
            //Console.WriteLine(fourthLoanAcc.CalcInterestForPeriod(24));
            //Console.WriteLine(firstLoanAcc.DepositeMoney(10));
           
            MortgageAccount firstMortgageAcc = new MortgageAccount(firstIndCustomer, 1000.00m, 0.2m);
            MortgageAccount secondMortgageAcc = new MortgageAccount(firstCompCustomer, 1000.00m, 0.2m);
            MortgageAccount thirdMortgageAcc = new MortgageAccount(secondIndCustomer, 1000.00m, 0.2m);
            MortgageAccount fourthMortgageAcc = new MortgageAccount(thirdCompCustomer, 1000.00m, 0.2m);
            //Console.WriteLine("{0:F2}", firstMortgageAcc.CalcInterestForPeriod(0));
            //Console.WriteLine("{0:F2}", secondMortgageAcc.CalcInterestForPeriod(11));
            //Console.WriteLine("{0:F2}", thirdMortgageAcc.CalcInterestForPeriod(7));
            //Console.WriteLine("{0:F2}", fourthMortgageAcc.CalcInterestForPeriod(56));
            Console.WriteLine(firstMortgageAcc.DepositeMoney(10));



        } 
    }
}
