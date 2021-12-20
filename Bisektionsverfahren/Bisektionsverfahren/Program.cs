using System;

namespace Bisektionsverfahren
{
    class Program
    {
        static void Main(string[] args)
        {
            // should be good
            double a1 = 1;
            double b1 = 2;

            // a and b switched
            double a2 = 2;
            double b2 = 1;

            // interval to far to right
            double a3 = 2;
            double b3 = 3;

            // interval to far to left
            double a4 = 0;
            double b4 = 1;

            Console.WriteLine($"A = '{a1}', B = '{b1}', return value = '{CalculateRootOfPolynomial(a1, b1)}'");
            Console.WriteLine($"A = '{a2}', B = '{b2}', return value = '{CalculateRootOfPolynomial(a2, b2)}'");
            Console.WriteLine($"A = '{a3}', B = '{b3}', return value = '{CalculateRootOfPolynomial(a3, b3)}'");
            Console.WriteLine($"A = '{a4}', B = '{b4}', return value = '{CalculateRootOfPolynomial(a4, b4)}'");
        }

        public static double ContinousFunction(double x)
        {
            return Math.Pow(x, 3) + x - 5;
        }

        public static double CalculateRootOfPolynomial(double a, double b)
        {
            Console.WriteLine($"------------------------\nCalculate root of polynomial interval a='{a}' b='{b}'");

            int i = 0;
            double midPoint = double.NaN;
            int maxIterations = 1000;
            double tolerance = 1E-6;

            if (a >= b)
            {
                Console.WriteLine($"a ('{a}') >= b ('{b}'). Bad interval: returning '{midPoint}'.");
                return midPoint;
            }

            if ((ContinousFunction(a) >= 0 || ContinousFunction(b) <= 0)
                && (ContinousFunction(a) <= 0 || ContinousFunction(b) >= 0))
            {
                Console.WriteLine($"( f('{a}') = {ContinousFunction(a)} >= 0 || f('{b}') = {ContinousFunction(b)} <= 0 ) &&");
                Console.WriteLine($"( f('{a}') = {ContinousFunction(a)} <= 0 || f('{b}') = {ContinousFunction(b)} >= 0 )");
                Console.WriteLine($"Bad interval: returning '{midPoint}'");
                return midPoint;
            }

            while (i < maxIterations)
            {
                midPoint = (a + b) / 2.0;

                if (ContinousFunction(midPoint) == 0.0 || b - a < tolerance)
                {
                    break;
                }

                if (Math.Sign(ContinousFunction(midPoint)) == Math.Sign(ContinousFunction(a)))
                {
                    a = midPoint;
                }
                else
                {
                    b = midPoint;
                }

                i++;
            }

            return midPoint;
        }
    }
}
