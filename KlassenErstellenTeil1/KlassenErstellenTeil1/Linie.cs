using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenErstellenTeil1
{
    class Linie
    {
        public Punkt startPunkt;
        public Punkt endPunkt;

        public Punkt StartPunkt()
        {
            return startPunkt;
        }

        public void StartPunkt(Punkt startPunkt)
        {
            this.startPunkt = startPunkt;
        }

        public Punkt EndPunkt()
        {
            return endPunkt;
        }

        public void EndPunkt(Punkt endPunkt)
        {
            this.endPunkt = endPunkt;
        }

        public double Laenge()
        {
            return startPunkt.AbstandZu(endPunkt);
        }

        public override string ToString()
        {
            return $"Startpunkt: [{startPunkt.ToString()}], Endpunkt: [{endPunkt.ToString()}], Länge: '{Laenge()}'";
        }
    }
}
