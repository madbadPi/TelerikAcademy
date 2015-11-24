using System;

class Carpet
{
    static void Main()
    {
        string consoleInput = Console.ReadLine();
        int lines = int.Parse(consoleInput);
        int elementOnline = lines;
        int center = elementOnline / 2;
        for (int i = 1; i <= (lines/2); i++)
        {
            int elementPos = 1;
            while(elementPos <= elementOnline)
            {
                if ((elementPos <= (center - i)) || (elementPos > (center + i)))
                {
                    Console.Write(".");
                    elementPos++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("/");
                            elementPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elementPos++;
                        }
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("\\");
                            elementPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elementPos++;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
        for (int i = (lines / 2); i >= 1; i--)
        {
            int elementPos = 1;
            while(elementPos <= elementOnline)
            {
                if ((elementPos <= (center - i)) || (elementPos > (center + i)))
                {
                    Console.Write(".");
                    elementPos++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("\\");
                            elementPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elementPos++;
                        }
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("/");
                            elementPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elementPos++;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
