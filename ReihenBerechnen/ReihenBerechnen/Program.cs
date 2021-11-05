using System;

namespace ReihenBerechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teil 1
            uint n1 = 10;
            uint n2 = 25;

            decimal resultN1 = BerechneSumme1MitEndwert(n1);
            decimal resultN2 = BerechneSumme1MitEndwert(n2);

            Console.WriteLine($"Result of '{nameof(n1)}' ('{n1}') is '{resultN1}'.");
            Console.WriteLine($"Result of '{nameof(n2)}' ('{n2}') is '{resultN2}'.");

            // Teil 2
            uint n3 = 100;
            uint n4 = 1000;

            decimal resultN3 = BerechneSumme2MitEndwert(n3);
            decimal resultN4 = BerechneSumme2MitEndwert(n4);

            Console.WriteLine($"Result of '{nameof(n3)}' ('{n3}') is '{resultN3}'.");
            Console.WriteLine($"Result of '{nameof(n4)}' ('{n4}') is '{resultN4}'.");
        }

        // Rekursive Fakultät Methode
        public static decimal FakultaetVon(uint zahl)
        {
            // 0! oder 1! sind jeweils 1 (Abbruchbedingung für Rekursion)
            if (zahl <= 1)
            {
                return 1;
            }

            // Da n! = n * (n-1)! -> zahl ist hier n
            return zahl * FakultaetVon(zahl - 1);
        }

        // Kernmethode Teil 1
        public static decimal BerechneSumme1MitEndwert(uint endwert)
        {
            // initialisieren der Summe mit 0
            decimal sum = 0;

            for (uint i = 0; i <= endwert; i++)
            {
                // Berechnen der Fakultät im Nenner
                decimal iFakultaet = FakultaetVon(i);

                // Berechnen der Iteration und auf Summe aufaddieren
                sum += 1 / iFakultaet;
            }

            // Rückgabe der Summe
            return sum;
        }

        // Kernmethode Teil 2
        public static decimal BerechneSumme2MitEndwert(uint endwert)
        {
            // Initialisieren der Summe mit 0
            decimal sum = 0;

            for (uint i = 0; i <= endwert; i++)
            {
                // Berechnung der Potenz
                double powerOfI = Math.Pow(-1, i);

                // Konvertieren zum Zieltyp Decimal
                decimal powerOfIAsDecimal = Convert.ToDecimal(powerOfI);

                // Berechnung
                sum += powerOfIAsDecimal / (2m * i + 1m);
            }

            // Rückgabe der Summe mal 4
            return sum * 4;
        }
    }
}
