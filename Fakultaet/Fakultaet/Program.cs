using System;

namespace Fakultaet
{
    class Program
    {
        static void Main(string[] args)
        {
            for(uint i = 0; i < 25; i++)
            {
                ulong iFactorial = CalculateFactorial(i);
                Console.WriteLine($"{i}! = '{iFactorial}'");
            }
        }

        /// <summary>
        /// Takes a uint number and calculates its factorial.
        /// </summary>
        /// <param name="number">The number of which the factorial should be calculated.</param>
        /// <returns>the factorial of the parameter number as an ulong.</returns>
        public static ulong CalculateFactorial(uint number)
        {
            if(number <= 1)
            {
                return number;
            }

            return number * CalculateFactorial(number - 1);
        }
    }
}
