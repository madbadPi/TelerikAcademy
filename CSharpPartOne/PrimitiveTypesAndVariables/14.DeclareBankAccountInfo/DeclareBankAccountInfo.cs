using System;

class DeclareBankAccountInfo
{
    static void Main()
    {
        string firstName = "Ivan";
        string secondName = "Ivanov";
        string thirdName = "Petrov";
        string fullName = firstName + ' ' + secondName + ' ' + thirdName;
        decimal holderBalance = 100000.00m;
        string bankName = "Raiffeisenbank";
        string iban = "BG60RZBB91551097203080";
        string bic = "RZBBBGSF";
        long creditCardNum1 = 67607188972030001;
        long creditCardNum2 = 67607188972030002;
        long creditCardNum3 = 67607188972030003;
        Console.WriteLine("Account holder:\n" + fullName);
        Console.WriteLine("Bank name:\n{0}\nBIC code:\n{1}", bankName, bic);
        Console.WriteLine("IBAN:\n" + iban);
        Console.WriteLine("Account balance:\n" + holderBalance);
        Console.WriteLine("Associated credit card numbers:\n" + creditCardNum1 + "\n" + creditCardNum2 + "\n" + creditCardNum3 + "\n");
    }
}
