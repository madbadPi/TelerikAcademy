using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class CountRepeatingWordInFileFromList
{
    private static void WriteToOutPutFile(string[] words, int[] counter)
    {
        using (StreamWriter output = new StreamWriter("../../output.txt"))
            for (int i = 0; i < words.Length; i++)
                output.WriteLine("{0} {1}", words[i], counter[i]);
    }

    private static void CountWords(string[] words, int[] counter)
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            for (string line; (line = input.ReadLine()) != null; )
            {
                for (int i = 0; i < words.Length; i++)
                {
                    counter[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                }
            }
        }
    }
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("../../list.txt");
            int[] repetition = new int[words.Length];

            CountWords(words, repetition);            
            Array.Sort(repetition, words);
            WriteToOutPutFile(words, repetition);
            
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
        //catch (Exception exception)
        //{
        //    Console.WriteLine(exception.Message);
        //}
    }    
}
