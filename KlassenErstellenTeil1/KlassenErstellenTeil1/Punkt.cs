using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenErstellenTeil1
{
    class Punkt
    {
        public double X;
        public double Y;
        public double Z;

        public double GetX()
        {
            return X;
        }

        public void SetX(double x)
        {
            this.X = x;
        }

        public double GetY()
        {
            return Y;
        }

        public void SetY(double y)
        {
            this.Y = y;
        }

        public double GetZ()
        {
            return Z;
        }

        public void SetZ(double z)
        {
            this.Z = z;
        }

        public double AbstandZu(Punkt endPunkt)
        {
            double deltaX = X - endPunkt.GetX();
            double deltaY = Y - endPunkt.GetY();
            double deltaZ = Z - endPunkt.GetZ();
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
        }

        public static double AbstandZwischen(Punkt startPunkt, Punkt endPunkt)
        {
            return startPunkt.AbstandZu(endPunkt);
        }

        override public string ToString()
        {
            return $"X: '{X}', Y: '{Y}', Z: '{Z}'";
        }
    }
}
