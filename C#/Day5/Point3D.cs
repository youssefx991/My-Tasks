using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Day5
{
    internal class Point3D
    {
        // attributes
        public double x {  get; set; }
        public double y {  get; set; }
        public double z {  get; set; }

        // constructors
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point3D():this(0,0,0) { }
        public Point3D(double x):this(x,0,0) { }
        public Point3D(double x, double y):this(x,y,0) { }


        public Point3D(Point3D point)
        {
            this.x= point.x;
            this.y= point.y;
            this.z= point.z;
        }


        // operator overloading
        public static bool operator ==(Point3D a, Point3D b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }
        public static bool operator !=(Point3D a, Point3D b)
        {
            return a.x != b.x || a.y != b.y || a.z != b.z;
        }


        // casting
        public static explicit operator string(Point3D point)
        {
            return point.ToString(); 
        }

        // tostring
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        // equals
        public override bool Equals(object? point)
        {
            if (point == null) 
                return false;

            if (point is Point3D)
            {
                return this == (Point3D)point;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, z);
        }
    }
}
