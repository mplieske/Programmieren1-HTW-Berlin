using System;

namespace MathematischeFunktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teil 1
            int result = Sub(Mul(Add(1, 2), 42), 1);
            Console.WriteLine($"(1 + 2) * 42 - 1 = '{result}'");

            // Teil 2
            uint a = 10;
            uint b = 3;
            result = Mod(a, b);
            Console.WriteLine($"'{a}' modulo '{b}' = '{result}'");

            // Teil 3
            uint evenNumber = 8;
            uint oddNumber = 13;
            Console.WriteLine($"'{evenNumber}' is even: '{IsEven(evenNumber)}'");
            Console.WriteLine($"'{oddNumber}' is even: '{IsEven(oddNumber)}'");
        }

        // Teil 1
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }

        // Teil 2
        public static int Mod(uint a, uint b)
        {
            // Calculate which smaller number would be divisible.
            uint integerDivisionResult = a / b;
            uint asdf = integerDivisionResult * b;

            // Return difference between smaller divisible number and actual number.
            return Convert.ToInt32(a - asdf);
        }

        // Teil 3
        public static bool IsEven(uint x)
        {
            // If a number is divisible by two it is even.
            return Mod(x, 2) == 0;
        }
    }
}
