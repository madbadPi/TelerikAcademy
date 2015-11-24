using System;

class ShipDamage
{
    static void Main()
    {
        int sX1 = int.Parse(Console.ReadLine());
        int sY1 = int.Parse(Console.ReadLine());

        int sX2 = int.Parse(Console.ReadLine());
        int sY2 = int.Parse(Console.ReadLine());

        int horizontal = int.Parse(Console.ReadLine());

        int cX1 = int.Parse(Console.ReadLine());
        int cY1 = int.Parse(Console.ReadLine());

        int cX2 = int.Parse(Console.ReadLine());
        int cY2 = int.Parse(Console.ReadLine());

        int cX3 = int.Parse(Console.ReadLine());
        int cY3 = int.Parse(Console.ReadLine());

        cY1 = 2 * horizontal - cY1;
        cY2 = 2 * horizontal - cY2;
        cY3 = 2 * horizontal - cY3;
        int result = 0;
        if (sX1 > sX2)
        {
            int bigger = sX1;
            sX1 = sX2;
            sX2 = bigger;            
        }
        if (sY1 > sY2)
            {
                int bigger = sY1;
                sY1 = sY2;
                sY2 = bigger;
            }
        if ((sX1 < cX1) && (cX1 < sX2) && (sY1 < cY1) && (cY1 < sY2))
        {
            result += 100;
        }
        if ((sX2 == cX1 || cX1 == sX1) && (sY1 < cY1 && cY1 < sY2))
        {
            result += 50;
        }

        if ((sX1 < cX1 && cX1 < sX2) && (sY1 == cY1 || cY1 == sY2))
        {
            result += 50;
        }

        if ((sX2 == cX1 || cX1 == sX1) && (sY1 == cY1 || cY1 == sY2))
        {
            result += 25;
        }

        cX1 = cX2;
        cY1 = cY2;

        if ((sX1 < cX1) && (cX1 < sX2) && (sY1 < cY1) && (cY1 < sY2))
        {
            result += 100;
        }
        if ((sX2 == cX1 || cX1 == sX1) && (sY1 < cY1 && cY1 < sY2))
        {
            result += 50;
        }

        if ((sX1 < cX1 && cX1 < sX2) && (sY1 == cY1 || cY1 == sY2))
        {
            result += 50;
        }

        if ((sX2 == cX1 || cX1 == sX1) && (sY1 == cY1 || cY1 == sY2))
        {
            result += 25;
        }
        
        cX1 = cX3;
        cY1 = cY3;

        if ((sX1 < cX1) && (cX1 < sX2) && (sY1 < cY1) && (cY1 < sY2))
        {
            result += 100;
        }
        if ((sX2 == cX1 || cX1 == sX1) && (sY1 < cY1 && cY1 < sY2))
        {
            result += 50;
        }

        if ((sX1 < cX1 && cX1 < sX2) && (sY1 == cY1 || cY1 == sY2))
        {
            result += 50;
        }

        if ((sX2 == cX1 || cX1 == sX1) && (sY1 == cY1 || cY1 == sY2))
        {
            result += 25;
        }
        Console.WriteLine(result + "%");

    }
}
