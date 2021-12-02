using System;
using System.Collections.Generic;

namespace Primzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            uint obergrenze;
            bool retry = false;
            do
            {
                Console.WriteLine("Bitte obere Grenze n (<= 100.000) für Berechnung der Primzahlen eingeben:");
                string input = Console.ReadLine();

                retry = false;
                if (!uint.TryParse(input, out obergrenze) || obergrenze > 100000)
                {
                    Console.WriteLine("Falsche Zahl. Nochmal versuchen? (j/N)");
                    input = Console.ReadLine();
                    retry = input.Equals("j");
                    if (!retry)
                    {
                        System.Environment.Exit(0);
                    }
                }
            } while (retry);
            Console.WriteLine($"obergrenze '{obergrenze}'");
            uint[] primnumbers = CalculatePrimeNumbers(obergrenze);
            Console.WriteLine($"Primnumbers under {obergrenze + 1}:");
            foreach (uint uInt in primnumbers)
            {
                Console.Write($"|{uInt}| ");
            }
        }

        /// <summary>
        /// Ermittelt alle Primzahlen bis einschließlich number.
        /// </summary>
        /// <param name="number">Obergrenze für berechnung</param>
        /// <returns>array mit allen primzahlen bis einschließlich number.</returns>
        public static uint[] CalculatePrimeNumbers(uint number)
        {
            if (number < 2)
            {
                return new uint[0];
            }

            bool[] sieb = new bool[number + 1];
            sieb[0] = false;
            sieb[1] = false;

            for (uint i = 2; i < sieb.Length; i++)
            {
                sieb[i] = true;
            }

            for (int i = 2; i < sieb.Length; i++)
            {
                if (!sieb[i])
                {
                    continue;
                }

                for (int j = i + i; j < sieb.Length; j += i)
                {
                    sieb[j] = false;
                }
            }

            List<uint> primnumbers = new List<uint>();
            for (uint i = 0; i < sieb.Length; i++)
            {
                if (!sieb[i])
                {
                    continue;
                }
                primnumbers.Add(i);
            }

            return primnumbers.ToArray();
        }
    }
}
