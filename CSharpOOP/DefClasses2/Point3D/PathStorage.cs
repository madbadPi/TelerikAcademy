namespace Point3D
{
    using System;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePathsInFile(Path newPath)
        {
            string filePath = @"../../PathStorage.txt";
            StreamWriter output = new StreamWriter(filePath);
            using (output)
            {
                output.WriteLine(newPath.FirstPoint);
                output.WriteLine(newPath.SecondPoint);
                output.WriteLine(newPath.ThirdPoint);
            }
        }

        public static Path LoadPathsFromFile(string filePath)
        {
            Path newPath;
            StreamReader input = new StreamReader(filePath);
            int numCoord = 3;
            int numPoints = 3;
            using(input)
            {
                int counter = 0;
                decimal[,] coordinates = new decimal[numPoints, numCoord];
                for (string line; (line = input.ReadLine()) != null; counter++)
                {
                    string[] coord = line.Split(',');
                    for (int i = 0; i < numCoord; i++)
                    {
                        coordinates[counter, i] = decimal.Parse(coord[i]);
                    }                    
                }
                newPath = new Path(new Point3D(coordinates[0, 0], coordinates[0, 1], coordinates[0, 2]),
                    new Point3D(coordinates[1, 0], coordinates[1, 1], coordinates[1, 2]),
                    new Point3D(coordinates[2, 0], coordinates[2, 1], coordinates[2, 2]));
                return newPath;
            }            
        }
    }
}
