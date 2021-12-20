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

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        /// <summary>
        /// Calculates the scalar product of this Vektor and another one.
        /// </summary>
        /// <param name="b">The other Vektor instance.</param>
        /// <returns>Returns the scalar product of this Vektor and b as double.</returns>
        public double BerechneSkalarprodukt(Vektor b)
        {
            return x * b.X + y * b.Y + z * b.Z;
        }

        /// <summary>
        /// Calculates the scalar product of two Vektor instances.
        /// </summary>
        /// <param name="a">First Vektor instance</param>
        /// <param name="b">Second Vektor instance</param>
        /// <returns>Returns scalar product of a and b as double.</returns>
        public static double BerechneSkalarprodukt(Vektor a, Vektor b)
        {
            return a.BerechneSkalarprodukt(b);
        }

        /// <summary>
        /// Generates a JSON string representation of this Vektor.
        /// </summary>
        /// <returns>Returns the generated JSON string.</returns>
        public override string ToString()
        {
            return $"{{X: '{X}', Y: '{Y}', Z: '{Z}'}}";
        }
    }
}
