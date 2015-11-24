using System;
using System.IO;
using System.Text;

class CompareTextFilesLines
{
    static void Main()
    {        
        using(StreamReader firstInput = new StreamReader("../../test1.txt"))
        using (StreamReader secondInput = new StreamReader("../../test2.txt"))
        {
            int counter = 0;
            int sameCounter = 0;
            for (string line; (line = firstInput.ReadLine()) != null; counter++)
            {
                if (line == secondInput.ReadLine())
                {
                    sameCounter++;
                }
            }
            Console.WriteLine("The number of same lines is {0}", sameCounter);
            Console.WriteLine("The number of different lines is {0}", counter - sameCounter);
        }
        
    }
}
