namespace Geometry
{
    using System;

    public abstract class Shape
    {
        private decimal width;
        private decimal height;

        public Shape(decimal figureWidth, decimal figureHeight)
        {
            this.Width = figureWidth;
            this.Height = figureHeight;
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The width can't be negative or zero");
                }
                this.width = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The height can't be negative or zero");
                }
                this.height = value;
            }
        }

        public abstract decimal CalculateSurface();
    }
}
