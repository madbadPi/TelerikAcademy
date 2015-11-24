using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

public class CalcExpression
{
    public static List<char> arithmeticOperation = new List<char> { '+', '-', '*', '/'};
    
    private static List<string> SeparateToken(string input)
    {
        var result = new List<string>();
        var number = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
            {
                number.Append('-');
            }
            else if (char.IsDigit(input[i]) || input[i] == '.')
            {
                number.Append(input[i]);
            }
            else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length !=0)
            {
                result.Add(number.ToString());
                number.Clear();
                i--;
            }
            if (input[i] == '(')
            {
                result.Add("(");
            }
            else if (input[i] == ')')
            {
                result.Add(")");
            }
            else if (arithmeticOperation.Contains(input[i]))
            {
                result.Add(input[i].ToString());
            }
            else if (input[i] == ',')
            {
                result.Add(",");
            }

            else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
            {
                result.Add("ln");
                i++;
            }
            else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
            {
                result.Add("pow");
                i += 2;
            }
            else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
            {
                result.Add("ln");
                i += 3;
            }
            else if (number.Length != '0')
            {
                result.Add(number.ToString());
            }
            else
            {
                throw new ArgumentException("Invalid expression");
            }


        }
        return result;
    }

    public static string TrimInput(string input)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                result.Append(input[i]);
            }
        }
        return result.ToString();
    }
    public static void PutInvariantCulture()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
    }

    public static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(TrimInput(input));        
        var separateToken = SeparateToken(TrimInput(input));
        
        //convert into a queue RPN
        //calc the final result         
    }    
}
