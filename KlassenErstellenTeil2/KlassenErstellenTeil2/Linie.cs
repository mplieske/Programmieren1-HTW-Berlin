using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenErstellenTeil2
{
    class Linie
    {
        public Punkt StartPunkt { get; set; }
        public Punkt EndPunkt { get; set; }

        public double Laenge
        {
            get { return StartPunkt.AbstandZu(EndPunkt); }
        }

        public Linie(Punkt startPunkt, Punkt endPunkt)
        {
            StartPunkt = startPunkt;
            EndPunkt = endPunkt;
        }

        /// <summary>
        /// Moves a Linie by a Vektor.
        /// </summary>
        /// <param name="verschiebeVektor">Vektor to move the Linie by.</param>
        /// <returns>Returns a new Linie which is this Linie moved by the Vektor verschiebeVektor.</returns>
        public Linie VerschiebeUmVektor(Vektor verschiebeVektor)
        {
            Punkt startPunkt = StartPunkt.AlsVektor().Addiere(verschiebeVektor).AlsPunkt();
            Punkt endPunkt = EndPunkt.AlsVektor().Addiere(verschiebeVektor).AlsPunkt();
            return new Linie(startPunkt, endPunkt);
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
