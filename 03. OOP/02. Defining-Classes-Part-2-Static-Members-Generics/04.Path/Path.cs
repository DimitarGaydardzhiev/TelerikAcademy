using System;
using System.Collections.Generic;

namespace Path
{
    public class Path
    {
        private List<Point3D> pointsSequence = new List<Point3D>();

        public List<Point3D> PointsSequence
        {
            get
            {
                return this.pointsSequence;
            }
        }

        public void AddPoints(Point3D point)
        {
            pointsSequence.Add(point);
        }

        public void ClearPoints()
        {
            pointsSequence.Clear();
        }
    }
}
