using System;

namespace KlassenErstellenTeil1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some sample data for testing.
            Punkt p1 = new Punkt();
            p1.X = 0;
            p1.Y = 0;
            p1.Z = 0;

            Punkt p2 = new Punkt();
            p2.X = 15;
            p2.Y = 0;
            p2.Z = 0;

            Vektor v1 = new Vektor();
            v1.X = 1;
            v1.Y = 0;
            v1.Z = 1;

            Vektor v2 = new Vektor();
            v2.X = 0;
            v2.Y = 1;
            v2.Z = 0;

            Linie l = new Linie();
            l.StartPunkt = p1;
            l.EndPunkt = p2;

            // Do some calculations. As the static method uses the instance method, we simply use those where possible.
            double abstandP1P2 = Punkt.AbstandZwischen(p1, p2);
            double laengeL = l.Laenge;
            double skalarproduktV1V2 = Vektor.BerechneSkalarprodukt(v1, v2);

            // Test ToString methods.
            Console.WriteLine("p1: " + p1.ToString());
            Console.WriteLine("p2: " + p2.ToString());
            Console.WriteLine("v1: " + v1.ToString());
            Console.WriteLine("v2: " + v2.ToString());
            Console.WriteLine("l: " + l.ToString());

            // Print out the results of the calculations.
            Console.WriteLine($"Abstand zwischen p1 und p2: {abstandP1P2}");
            Console.WriteLine($"Länge der Linie l: {laengeL}");
            Console.WriteLine($"Skalarprodukt von v1 und v2: {skalarproduktV1V2}");
        }
    }
}
