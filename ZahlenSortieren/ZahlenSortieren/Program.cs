using System;
using System.Text;
using System.Linq;

namespace ZahlenSortieren
{
    class Program
    {
        static void Main(string[] args)
        {
            ZufallszahlenGenerator zufallszahlenGenerator = new ZufallszahlenGenerator(1000, -10, 10);
            int[] numbers = zufallszahlenGenerator.ErzeugeZufallszahlen();
            GebeArrayAus(numbers);
        }

        public static void GebeArrayAus(int[] zahlen)
        {
            int columnWidth = EvaluateColumnWidth(zahlen);
            GebeArrayAus(zahlen, 0, columnWidth);
        }

        private static void GebeArrayAus(int[] zahlen, int lineOfPage, int columnWidth)
        {
            if (zahlen.Length <= 0) // Abbruchbedingung
            {
                return;
            }

            string line = GenerateLine(zahlen, columnWidth);
            Console.WriteLine(line);

            lineOfPage += 1;
            if (lineOfPage >= Console.WindowHeight)
            {
                WaitForEnter();

                // reset lineOfPage as a new page begins
                lineOfPage = 0;
            }

            GebeArrayAus(zahlen.Skip(4).ToArray(), lineOfPage, columnWidth);
        }

        private static string GenerateLine(int[] zahlen, int columnWidth)
        {
            StringBuilder sb = new StringBuilder();

            // add first 4 numbers in array to string seperated by spaces
            for (int i = 0; i < zahlen.Length && i < 4; i++)
            {
                int number = zahlen[i];
                int leadingWhitespaces = columnWidth - EvaluateWidthOfNumber(number);

                // add leading whitespaces
                for (int j = 0; j < leadingWhitespaces; j++)
                {
                    sb.Append(" ");
                }
                sb.Append($"{number} ");
            }

            return sb.ToString();
        }

        private static void WaitForEnter()
        {
            Console.WriteLine("Bitte Enter für die nächste Seite drücken.");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                // Wait for Enter key.
            }
        }

        private static int EvaluateColumnWidth(int[] numbers)
        {
            // Search for the widest number in array
            int smallestNumberWidth = EvaluateWidthOfNumber(numbers[0]);
            int biggestNumberWidth = EvaluateWidthOfNumber(numbers[numbers.Length - 1]);
            int widestNumber = smallestNumberWidth >= biggestNumberWidth ? smallestNumberWidth : biggestNumberWidth;
            return widestNumber;
        }

        private static int EvaluateWidthOfNumber(int number)
        {
            // Negative numbers need one character more to print and zero will be skiped by loop.
            int width = number > 0 ? 0 : 1;
            number = Math.Abs(number);
            while (number >= 1)
            {
                width++;
                number /= 10;
            }

            return width;
        }
    }
}
