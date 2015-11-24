using System;

class TelerikLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int width = (x + x) + 2 * (x / 2 + 1) - 3;
        int horn = x / 2;
        int middelDot = width - 2 * (x / 2 + 1);
        Console.Write(new string('.', horn));
        Console.Write('*');
        Console.Write(new string('.', middelDot));
        Console.Write('*');
        Console.WriteLine(new string('.', horn));
        middelDot -= 2;
        int firstHorn = x / 2 - 1;
        int dotsAfterHorn = 0;

        for (int i = 1; i < x - 1; i++)
        {
            if (i <= x / 2)
            {
                Console.Write(new string('.', firstHorn));
                Console.Write('*');
                Console.Write(new string('.', dotsAfterHorn));
            }   
            else
            {
                Console.Write(new string('.', horn));
            }  

            Console.Write(new string('.', i));
            Console.Write('*');
                    
            Console.Write(new string('.', middelDot));
            middelDot -= 2;
            Console.Write('*');
            Console.Write(new string('.', i));

            if (i <= x / 2)
            {
                Console.Write(new string('.', dotsAfterHorn));
                Console.Write('*');
                Console.Write(new string('.', firstHorn));
            }
            else
            {
                Console.Write(new string('.', horn));
            }  
            Console.WriteLine();
            firstHorn--;
            dotsAfterHorn++;
        }
        Console.Write(new string('.', width/2));
        Console.Write('*');
        Console.WriteLine(new string('.', width / 2));
        middelDot = 1;
        int leftRightDots = x - 2;
        for (int i = 0; i < x-1; i++)
        {
            Console.Write(new string('.', horn));
            Console.Write(new string('.', leftRightDots));
            Console.Write('*');
            Console.Write(new string('.', middelDot));
            Console.Write('*');
            Console.Write(new string('.', leftRightDots));
            Console.Write(new string('.', horn));
            Console.WriteLine();
            middelDot += 2;
            leftRightDots--;
        }
        middelDot -= 4;
        for (int i = 1; i < x - 1; i++)
        {
            Console.Write(new string('.', horn));
            Console.Write(new string('.', i));
            Console.Write('*');        
            Console.Write(new string('.', middelDot));            
            Console.Write('*');
            Console.Write(new string('.', i));
            Console.Write(new string('.', horn));
            middelDot -= 2;
            Console.WriteLine();
        }
        Console.Write(new string('.', width / 2));
        Console.Write('*');
        Console.WriteLine(new string('.', width / 2));
    }
}
