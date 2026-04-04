using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Day5
{
    internal class Point3D : IComparable<Point3D>, ICloneable
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

        // gethashcode
        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, z);
        }

        public int CompareTo(Point3D? other)
        {
            if (other.Equals(null))
                return 1;

            int c1 = x.CompareTo(other.x);
            int c2 = y.CompareTo(other.y);
            int c3 = z.CompareTo(other.z);
            if (c1 != 0)
                return c1;
            else if (c2 != 0) 
                return c2;            
            else if (c3 != 0)
                return c3;

            return 0;
             
        }

        public object Clone()
        {
            return new Point3D(x, y, z);
        }
    }
}
