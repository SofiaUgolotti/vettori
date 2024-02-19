using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vettori
{
    internal class Vector
    {
        public readonly double X;
        public readonly double Y;
        public Vector(double x, double y)
        {  X = x; Y = y; }
        public static Vector operator +(Vector v1, Vector v2) 
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1, Vector v2) 
        { 
            return new Vector(v1.X-v2.X, v1.Y-v2.Y);
        }
        public static Vector operator *(Vector v1,double scalare) 
        {
            return new Vector(v1.X*scalare, v1.Y*scalare);
        }
        public static Vector operator *(double scalare,Vector v1)
        {
            return new Vector(scalare * v1.X, scalare * v1.Y);
        }
        public static Vector operator /(Vector v1,double scalare)
        {
            return new Vector(v1.X / scalare, v1.Y / scalare);
        }
        public static Vector operator +(Vector v1)
        {
            return +v1;
        }
        public static Vector operator -(Vector v1)
        {
            return -v1;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
