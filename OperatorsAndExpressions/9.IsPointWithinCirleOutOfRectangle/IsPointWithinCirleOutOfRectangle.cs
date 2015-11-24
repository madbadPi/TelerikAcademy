using System;

class IsPointWithinCirleOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter point coordinates P(x,y)");
        double pointX = int.Parse(Console.ReadLine());
        double pointY = int.Parse(Console.ReadLine());
        double circleCeterPointX = 1;
        double circleCeterPointY = 1;
        double radius = 3;
        bool isWithinCircle = (((pointX - circleCeterPointX) * (pointX - circleCeterPointX) + (pointY - circleCeterPointY) * (pointY - circleCeterPointY))) <= (radius * radius);
        bool isOutRectangle = ((pointX < -1) || (pointX > 5)) || ((pointY > 1) || (pointY < -1));
        if ((isWithinCircle) && isOutRectangle)
        {
            Console.WriteLine("Point({0},{1}) is within the circle K((1,1),3) and out of rectangle R(top=1, left=-1, width=6, height=2)", pointX, pointY);
        }
        else
        {
            Console.WriteLine("The point does not fulfill the conditions");
        }
    }
}