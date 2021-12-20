using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenErstellenTeil1
{
    class Linie
    {
        public Punkt StartPunkt { get; set; }
        public Punkt EndPunkt { get; set; }

        public double Laenge
        {
            get { return StartPunkt.AbstandZu(EndPunkt); }
        }

        /// <summary>
        /// Generates a JSON string representation of this Linie.
        /// </summary>
        /// <returns>Returns the generated JSON string.</returns>
        public override string ToString()
        {
            return $"{{StartPunkt: {StartPunkt}, EndPunkt: {EndPunkt}, Laenge: '{Laenge}'}}";
        }
    }
}
