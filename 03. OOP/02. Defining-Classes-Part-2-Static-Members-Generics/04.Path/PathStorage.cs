using System;
using System.IO;

namespace Path
{
    public static class PathStorage
    {
        public static void LavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter("save.txt"))
            {
                foreach (var point in path.PointsSequence)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static void LoadPath()
        {
            Path loadPath = new Path();
            using (StreamReader reader = new StreamReader("load.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    Point3D point = new Point3D();
                    string[] points = line.Split(' ');
                    point.X = decimal.Parse(points[0]);
                    point.Y = decimal.Parse(points[1]);
                    point.Z = decimal.Parse(points[2]);

                    loadPath.AddPoints(point);

                    line = reader.ReadLine();
                }
            }
        }
    }
}
