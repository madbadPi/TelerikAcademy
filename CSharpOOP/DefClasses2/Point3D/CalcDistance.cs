namespace Point3D
{
    using System;
    public static class CalcDistance
    {
        public static decimal CalcBetween(Point3D a, Point3D b)
        {
            decimal distance = 0.0m;
            decimal distanceX = a.CoordX - b.CoordX;
            decimal distanceY = a.CoordY - b.CoordY;
            decimal distanceZ = a.CoordZ - b.CoordZ;
            distance = (decimal)Math.Sqrt((double)(distanceX*distanceX + distanceY*distanceY + distanceZ*distanceZ));
            return distance;
        }
    }
}