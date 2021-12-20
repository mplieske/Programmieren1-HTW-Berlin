using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenErstellenTeil1
{
    class Punkt
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

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
        /// Generates a JSON string representation of this Punkt.
        /// </summary>
        /// <returns>Returns the generated string in JSON.</returns>
        public override string ToString()
        {
            return $"{{X: '{X}', Y: '{Y}', Z: '{Z}'}}";
        }
    }
}
