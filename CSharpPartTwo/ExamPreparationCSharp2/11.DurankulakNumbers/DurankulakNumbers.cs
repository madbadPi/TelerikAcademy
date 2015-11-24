using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DurankulakNumbers
{
    static void Main(string[] args)
    {
        string[] durankulakDigits = GetDurankulakDigits();
        string durankulakNumbers = Console.ReadLine();
        List<uint> decimalRepresentations = GetDecimalRepresentation(durankulakDigits, durankulakNumbers);
        ulong decimalNumber = GetDecimalNum(decimalRepresentations);
        Console.WriteLine(decimalNumber);
    }

    private static ulong GetDecimalNum(List<uint> decimalRepresentations)
    {
        ulong result = 0;
        for (int i = 0; i < decimalRepresentations.Count; i++)
        {
            result += decimalRepresentations[decimalRepresentations.Count - i - 1] * (ulong)Math.Pow(168, i);
        }
        return result;
    }

    private static List<uint> GetDecimalRepresentation(string[] durankulagdigits, string durankulakNumbers)
    {
        List<uint> decimalRepresentations = new List<uint>();
        char buffer = new char();
        foreach (char symbol in durankulakNumbers)
        {
            if (symbol >= 'A' && symbol <= 'Z')
            {
                string durankulakDigit = null;
                uint decimalRepresentation = 0;
                if (buffer != default(char))
                {
                    durankulakDigit = (buffer + symbol).ToString();
                    buffer = default(char);
                }
                else
                {
                    durankulakDigit = symbol.ToString();                    
                }
                decimalRepresentation = (uint)Array.IndexOf(durankulagdigits, durankulakDigit);
                decimalRepresentations.Add(decimalRepresentation);
            }
            else
            {
                buffer = symbol;
            }
        }
        return decimalRepresentations;
    }

    private static string[] GetDurankulakDigits()
    {
        string[] durankulakDigits = new string[168];

        for (int i = 0; i < durankulakDigits.Length; i++)
        {
            if (i < 26)
            {
                durankulakDigits[i] = ((char)('A' + i)).ToString() ;
            }
            else if (i < 2 * 26)
            {
                durankulakDigits[i] = "a" + durankulakDigits[i - 1 * 26];
            }

            else if (i < 3 * 26)
            {
                durankulakDigits[i] = "b" + durankulakDigits[i - 2*26];
            }

            else if (i < 4 * 26)
            {
                durankulakDigits[i] = "c" + durankulakDigits[i - 3*26];
            }
            else if (i < 5 * 26)
            {
                durankulakDigits[i] = "d" + durankulakDigits[i - 4*26];
            }
            else if (i < 6 * 26)
            {
                durankulakDigits[i] = "e" + durankulakDigits[i - 5*26];
            }

            else if (i < 168)
            {
                durankulakDigits[i] = "f" + durankulakDigits[i - 6*26];
            }
        }
        return durankulakDigits;
    }
}

