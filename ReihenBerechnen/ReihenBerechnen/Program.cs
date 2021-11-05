using System;

namespace ReihenBerechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static decimal FakultaetVon(uint zahl)
        {
            if (zahl <= 1)
            {
                return zahl;
            }

            return FakultaetVon(zahl - 1);
        }

        public static decimal BerechneSumme1MitEndwert(uint endwert)
        {
            decimal number = 1;
            for (uint i = 1; i <= endwert; i++)
            {
                number += 1 / FakultaetVon(i);
            }
            return number;
        }
    }
}
