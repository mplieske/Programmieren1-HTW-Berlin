using System;

namespace KlassenErstellenTeil1
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt();
            p1.SetX(0);
            p1.SetY(0);
            p1.SetZ(1);

            Punkt p2 = new Punkt();
            p2.SetX(0);
            p2.SetY(0);
            p2.SetZ(2);

            Vektor v1 = new Vektor();
            v1.SetX(0);
            v1.SetY(1);
            v1.SetZ(0);

            Vektor v2 = new Vektor();
            v2.SetX(1);
            v2.SetY(0);
            v2.SetZ(0);

            Linie l = new Linie();
            l.StartPunkt(p1);
            l.EndPunkt(p2);

            double abstandP1P2 = Punkt.AbstandZwischen(p1, p2);
            double laengeL = l.Laenge();
            double skalarproduktV1V2 = Vektor.BerechneSkalarprodukt(v1, v2);

            Console.WriteLine("p1: " + p1.ToString());
            Console.WriteLine("p2: " + p2.ToString());
            Console.WriteLine("v1: " + v1.ToString());
            Console.WriteLine("v2: " + v2.ToString());
            Console.WriteLine("l: " + l.ToString());

            Console.WriteLine($"Abstand zwischen p1 und p2: {abstandP1P2}");
            Console.WriteLine($"Länge der Linie l: {laengeL}");
            Console.WriteLine($"Skalarprodukt von v1 und v2: {skalarproduktV1V2}");
        }
    }
}
