using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenErstellenTeil2
{
    class Punkt
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        /// <summary>
        /// Constructor of Punkt.
        /// </summary>
        /// <param name="x">X cordinate of Punkt. (default = 0)</param>
        /// <param name="y">Y cordinate of Punkt. (default = 0)</param>
        /// <param name="z">Z cordinate of Punkt. (default = 0)</param>
        public Punkt(double x = 0, double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Calculates the distance to another Punkt instance.
        /// </summary>
        /// <param name="endPunkt">The other Punkt instance.</param>
        /// <returns>Returns the discance as double.</returns>
        public double AbstandZu(Punkt endPunkt)
        {
            double deltaX = endPunkt.X - X;
            double deltaY = endPunkt.Y - Y;
            double deltaZ = endPunkt.Z - Z;

            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
        }

        /// <summary>
        /// Calculates the distance between two Punkt instances.
        /// </summary>
        /// <param name="startPunkt">Starting point</param>
        /// <param name="endPunkt">Ending point</param>
        /// <returns>Returns the distance between startPunkt and endPunkt as double.</returns>
        public static double AbstandZwischen(Punkt startPunkt, Punkt endPunkt)
        {
            return startPunkt.AbstandZu(endPunkt);
        }

        /// <summary>
        /// Calculates a Vektor pointing in direction of endPunkt.
        /// </summary>
        /// <param name="endPunkt">Instance of Punkt, the returned Vektor is poining at.</param>
        /// <returns>Returns Vektor pointing at endPunkt.</returns>
        public Vektor BildeVektor(Punkt endPunkt)
        {
            double deltaX = endPunkt.X - X;
            double deltaY = endPunkt.Y - Y;
            double deltaZ = endPunkt.Z - Z;
            return new Vektor(deltaX, deltaY, deltaZ);
        }

        /// <summary>
        /// Returns this Punkt as a Vektor.
        /// </summary>
        /// <returns>Returns this Punkt as a Vektor.</returns>
        public Vektor AlsVektor()
        {
            return new Vektor(X, Y, Z);
        }

        /// <summary>
        /// Calculates a Vektor pointing from startPunkt to endPunkt.
        /// </summary>
        /// <param name="startPunkt">Starting Punkt of returned Vektor.</param>
        /// <param name="endPunkt">Ending Punkt of returned Vektor.</param>
        /// <returns>Returns Vektor pointing from startPunkt to endPunkt.</returns>
        public static Vektor BildeVektor(Punkt startPunkt, Punkt endPunkt)
        {
            return startPunkt.BildeVektor(endPunkt);
        }

        /// <summary>
        /// Generates a JSON string representation of this Punkt.
        /// </summary>
        /// <returns>Returns the generated string in JSON.</returns>
        public override string ToString()
        {
            return $"{{X: '{X}', Y: '{Y}', Z: '{Z}'}}";
        }
    }
}
