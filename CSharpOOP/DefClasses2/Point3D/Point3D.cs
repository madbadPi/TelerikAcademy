namespace Point3D
{
    using System;
    public struct Point3D
    {
        //private decimal coordX;
        //private decimal coordY;
        //private decimal coordZ;
        //
        private static readonly string startPoint = "0,0,0";

        public static string StartPoint
        {
            get
            {
                return startPoint;
            }
        }

        public decimal CoordX { get; set; }
        public decimal CoordY { get; set; }
        public decimal CoordZ { get; set; }
        
        public Point3D(decimal x, decimal y, decimal z):this()
        {
            this.CoordX = x;
            this.CoordY = y;
            this.CoordZ = z;
        }

        public override string ToString()
        {
            return this.CoordX + "," + this.CoordY + "," + this.CoordZ;
        }
    }
}
