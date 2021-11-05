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

        public static double CalculateFactorial(uint number)
        {
            if(number <= 1)
            {
                return number;
            }

            return number * CalculateFactorial(number - 1);
        }
    }
}
