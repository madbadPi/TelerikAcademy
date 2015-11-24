using System;

class LastDigitEngWord
{
    private static string GetLastDig(int inputNum)
    {
        string lastDigAsWord = "";
        int lastNum = inputNum - (inputNum / 10) * 10;
        string[] digitsAsWords = {"zero", "one", "two", "three", 
                                     "four", "five", "six", "seven", "eight", "nine"
                                 };
        return digitsAsWords[lastNum];
    } 

    static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());
        string word = GetLastDig(inputNum);
        Console.WriteLine("The last digit is {0}", word);
    }       
}
