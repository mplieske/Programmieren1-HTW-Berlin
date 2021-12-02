using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenErstellenTeil1
{
    class Vektor
    {
        private double x;
        private double y;
        private double z;

        public double GetX()
        {
            return x;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public double GetY()
        {
            return y;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public double GetZ()
        {
            return z;
        }

        public void SetZ(double z)
        {
            this.z = z;
        }

        public double BerechneSkalarprodukt(Vektor b)
        {
            return (x * b.GetX()) + (y * b.GetY()) + (z * b.GetZ());
        }

        public static double BerechneSkalarprodukt(Vektor a, Vektor b)
        {
            return a.BerechneSkalarprodukt(b);
        }

        override public string ToString()
        {
            return $"X: '{x}', Y: '{y}', Z: '{z}'";
        }
    }
}
