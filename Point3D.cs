using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double CalculateDistance(Point3D otherPoint)
    {
        double deltaX = X - otherPoint.X;
        double deltaY = Y - otherPoint.Y;
        double deltaZ = Z - otherPoint.Z;



        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    }
}