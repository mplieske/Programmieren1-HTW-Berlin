using System;
using System.Numerics;

namespace Fakultaet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (uint i = 0; i <= 100; i++)
            {
                BigInteger iFactorial = CalculateBigFactorial(i);
                Console.WriteLine($"{i}! = '{iFactorial}'");
            }
        }

        /// <summary>
        /// Takes a uint number and calculates its factorial.
        /// </summary>
        /// <param name="number">The number of which the factorial should be calculated.</param>
        /// <returns>The factorial of the parameter number as an ulong.</returns>
        public static ulong CalculateFactorial(uint number)
        {
            checked
            {
                if (number <= 1)
                {
                    return 1;
                }

                return number * CalculateFactorial(number - 1);
            }
        }

        public static BigInteger CalculateBigFactorial(uint number)
        {
            checked
            {
                if (number <= 1)
                {
                    return 1;
                }

                return number * CalculateBigFactorial(number - 1);
            }
        }
    }
}
