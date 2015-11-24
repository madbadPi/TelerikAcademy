using System;
namespace Geometry
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(decimal figureWidth, decimal figureHeight) 
            :base(figureWidth, figureHeight)
        {

        }

        public override decimal CalculateSurface()
        {
            return base.Height * base.Width;
        }
    }
}
