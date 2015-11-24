using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class RemoveFromFileFromAnother
{
    static void Main(string[] args)
    {
        try
        {
            string[] list = File.ReadAllLines("../../list.txt");
            string word = @"\b(" + String.Join("|", list) + @")\b";
            using (StreamReader input = new StreamReader("../../input.txt"))
            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                string line = String.Empty;
                while ((line = input.ReadLine()) != null)
                {
                    output.WriteLine(Regex.Replace(line, word, String.Empty));
                }
            }
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

    }
}
