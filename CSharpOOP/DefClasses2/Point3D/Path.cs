using System;
namespace Point3D
{
    public class Path
    {
        public Point3D FirstPoint { get; set; }
        public Point3D SecondPoint { get; set; }
        public Point3D ThirdPoint { get; set; }

        public Path()
        {            
        }

        public Path(Point3D a, Point3D b, Point3D c)
        {
            this.FirstPoint = a;
            this.SecondPoint = b;
            this.ThirdPoint = c;
        }

        public override string ToString()
        {
            return this.FirstPoint.CoordX + "," + this.FirstPoint.CoordY + "," + this.FirstPoint.CoordZ + "\n"
               + this.SecondPoint.CoordX + "," + this.SecondPoint.CoordY + "," + this.SecondPoint.CoordZ + "\n"
               + this.ThirdPoint.CoordX + "," + this.ThirdPoint.CoordY + "," + this.ThirdPoint.CoordZ;
        }
    }

}