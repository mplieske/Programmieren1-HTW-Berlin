using System;

namespace NewtonVerfahren
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 0;

            for (int i = 0; i < 15; i++)
            {
                double res = CalculateRootOfPolynomial(x0);
                Console.WriteLine($"Für '{x0}' ist das Ergebnis: '{res}'.");
                x0 += 0.1;
            }
        }

        /// <summary>
        /// Teil 1: Implementierung der Funktion f(x)=x^3-x-2
        /// </summary>
        /// <param name="x">x der Funktion f(x)</param>
        /// <returns>x^3-x-2 für parameter x</returns>
        public static double ContinousFunction(double x)
        {
            return Math.Pow(x, 3) - x - 2;
        }

        /// <summary>
        /// Teil 2:
        /// Implemeniteren der ersten Ableitung von f(x)=x^3-x-2
        /// f'(x)=3x^2-1
        /// </summary>
        /// <param name="x">x der Funktion f'(x)=3x^2-1</param>
        /// <returns>3x^2-1 für parameter x</returns>
        public static double DerivativeOfContinousFunction(double x)
        {
            return 3 * Math.Pow(x, 2) - 1;
        }

        /// <summary>
        /// Teil 3: Siehe Hilfsmethode
        /// </summary>
        /// <param name="x0">Startwert</param>
        /// <returns>Annäherung an die Nullstelle</returns>
        public static double CalculateRootOfPolynomial(double x0)
        {
            return CalculateRootOfPlynomialRecursiveHelpMethod(x0, 1);
        }

        private static double CalculateRootOfPlynomialRecursiveHelpMethod(double xn, double recursionDepth)
        {
            double number = Math.Abs(ContinousFunction(xn) / DerivativeOfContinousFunction(xn));

            if (recursionDepth > 1000 || number < Math.Pow(10, -6)) // Abbruchbedingung
            {
                return xn;
            }

            double nextX = xn - ContinousFunction(xn) / DerivativeOfContinousFunction(xn); // Kalkulation (Newton'sche Näherungsformel)
            return CalculateRootOfPlynomialRecursiveHelpMethod(nextX, recursionDepth + 1); // Rekursion
        }
    }
}
