using System;

namespace Fakultaet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateFactorial(5));
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
