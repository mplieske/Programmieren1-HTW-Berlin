using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenErstellenTeil2
{
    class Vektor
    {
        private double x;
        private double y;
        private double z;

        public Vektor(double x = 0, double y = 0, double z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

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
        /// Adds Vektors together.
        /// </summary>
        /// <param name="summanden">sumands</param>
        /// <returns>Returns a Vektor, which is the sum of this Vektor and all summanden.</returns>
        public Vektor Addiere(params Vektor[] summanden)
        {
            Vektor vektor = new Vektor(x, y, z);

            foreach (Vektor summand in summanden)
            {
                vektor.X += summand.X;
                vektor.Y += summand.Y;
                vektor.Z += summand.Z;
            }

            return vektor;
        }

        /// <summary>
        /// Subtracts all Vektors in subtrahenden from this Vektor.
        /// </summary>
        /// <param name="subtrahenden">subtrahenders</param>
        /// <returns>Returns the resulting Vektor.</returns>
        public Vektor Subtrahiere(params Vektor[] subtrahenden)
        {
            Vektor vektor = new Vektor(x, y, z);

            foreach (Vektor subtrahend in subtrahenden)
            {
                vektor.X -= subtrahend.X;
                vektor.Y -= subtrahend.Y;
                vektor.Z -= subtrahend.Z;
            }

            return vektor;
        }

        /// <summary>
        /// Does scalar multiplication.
        /// </summary>
        /// <param name="skalarfaktor">scalar factor</param>
        /// <returns>returns a Vektor equal to this Vektor multiplied by skalarfaktor.</returns>
        public Vektor MultipliziereSkalar(double skalarfaktor)
        {
            return new Vektor(x * skalarfaktor, y * skalarfaktor, z * skalarfaktor);
        }

        /// <summary>
        /// Calculates a Vektor which is the cross product of this Vektor and b.
        /// </summary>
        /// <param name="b">Vektor b where the result = this x b</param>
        /// <returns>Returns the cross product of this Vektor and the Vektor b</returns>
        public Vektor BildeKreuzprodukt(Vektor b)
        {
            double rX = y * b.Z - z * b.y;
            double rY = z * b.X - x * b.Z;
            double rZ = x * b.Y - y * b.X;
            return new Vektor(rX, rY, rZ);
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
        /// Returns this Vektor as a Punkt.
        /// </summary>
        /// <returns>Returns this Vektor as a Punkt.</returns>
        public Punkt AlsPunkt()
        {
            return new Punkt(x, y, z);
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
