namespace Geometry
{
    using System;

    public class Circle : Shape
    {
        private decimal radius;

        public Circle(decimal r)
            :base(r, r)
        {
            this.Radius = r;
        }

        public decimal Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The radis of the circle can't be less or equal to zero.");
                }
                this.radius = value;
            }
        }

        public override decimal CalculateSurface()
        {
            return (decimal)Math.PI * this.Radius * this.Radius;
        }
    }
}
