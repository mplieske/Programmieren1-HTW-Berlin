using System;

namespace IterationUndRekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UmdrehenIterativ("Hello World!"));
            Console.WriteLine(UmdrehenRekursiv("Hello World!"));

            CountDownIterativ(4);
            CountDownRekursiv(4);
        }

        /// <summary>
        /// Reverses a string itteratively
        /// </summary>
        /// <param name="eingabe">string to reverse</param>
        /// <returns>the reversed string</returns>
        public static string UmdrehenIterativ(string eingabe)
        {
            string backwardString = "";
            foreach (char c in eingabe)
            {
                backwardString = $"{c}{backwardString}";
            }
            return backwardString;
        }

        /// <summary>
        /// Reverses a String recursively
        /// </summary>
        /// <param name="eingabe">string to reverse</param>
        /// <returns>reversed string</returns>
        public static string UmdrehenRekursiv(string eingabe)
        {
            if (eingabe.Length <= 1)
            {
                return eingabe;
            }

            string subString = eingabe.Substring(1);
            return $"{UmdrehenRekursiv(subString)}{eingabe[0]}";
        }

        /// <summary>
        /// Count down to console itteratively
        /// </summary>
        /// <param name="t">seconds to count down</param>
        public static void CountDownIterativ(int t)
        {
            while (t >= 1)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(t);
                t--;
            }
        }

        /// <summary>
        /// Count down to console revursively
        /// </summary>
        /// <param name="t">seconds to count down</param>
        public static void CountDownRekursiv(int t)
        {
            if (t < 1)
            {
                return;
            }

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(t);
            CountDownRekursiv(t - 1);
        }
    }
}
