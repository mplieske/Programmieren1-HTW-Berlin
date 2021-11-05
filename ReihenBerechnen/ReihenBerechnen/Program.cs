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
    }
}
