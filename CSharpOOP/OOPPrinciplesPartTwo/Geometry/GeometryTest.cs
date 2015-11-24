namespace Geometry
{
    using System;
    using System.Collections.Generic;

    public class GeometryTest
    {
        public static void CalcSurface(IEnumerable<Shape> shapes)
        {
            foreach (var figure in shapes)
            {
                Console.WriteLine("{0} surface is {1}", figure.GetType().Name, figure.CalculateSurface());
            }
        }

        static void Main()
        {
            List<Shape> listOfShapes = new List<Shape>
            {
                new Rectangle(12, 5),
                new Rectangle(10, 5),
                new Triangle(3, 6),
                new Circle(5)                
            };

            CalcSurface(listOfShapes);
        }
    }
}
