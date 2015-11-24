namespace GSM
{
    using System;

    public class Display //?
    {
        private const int MaxNumColors = 16000000;//16M
        private const decimal MaxSize = 14.0m; // size is in inches

        private decimal size;
        private int numColors;

        public Display()
        {
            this.Size = 0.0m;
            this.NumColors = 0;
        }

        public Display(decimal currentSize) :this()
        {
            this.Size = currentSize;            
        }

        public Display(decimal currentSize, int currNumColors) : this(currentSize)
        {           
            this.NumColors = currNumColors;
        }

        public decimal Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value > MaxSize)
                {
                    throw new ArgumentOutOfRangeException("Display size can't be more than 14 inch");
                }
                this.size = value;
            }
        }

        public int NumColors
        {
            get
            {
                return this.numColors;
            }

            set
            {
                if (value > MaxNumColors)
                {
                    throw new ArgumentOutOfRangeException("Number of colors can't be more than 16M");
                }
                this.numColors = value;
            }
        }

        public override string ToString()
        {
            return this.Size + " inch " + numColors;
        }
    }
}
