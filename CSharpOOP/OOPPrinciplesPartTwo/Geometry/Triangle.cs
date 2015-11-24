using System;
namespace Geometry
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(decimal figureWidth, decimal figureHeight) 
            :base(figureWidth, figureHeight)
        {

        }

        public override decimal CalculateSurface()
        {
            return base.Height * (base.Width / 2);
        }
    }
}
