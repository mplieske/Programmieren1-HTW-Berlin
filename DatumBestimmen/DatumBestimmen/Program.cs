using System;

namespace DatumBestimmen
{
    public enum Wochentag
    {
        Sonntag = 0,
        Montag = 1,
        Dienstag = 2,
        Mittwoch = 3,
        Donnerstag = 4,
        Freitag = 5,
        Samstag = 6
    }

    public enum MonatGregorianisch
    {
        Januar = 1,
        Februar = 2,
        März = 3,
        April = 4,
        Mai = 5,
        Juni = 6,
        Juli = 7,
        August = 8,
        September = 9,
        Oktober = 10,
        November = 11,
        Dezember = 12
    }

    public enum MonatJulianisch
    {
        Januar = 11,
        Februar = 12,
        März = 1,
        April = 2,
        Mai = 3,
        Juni = 4,
        Juli = 5,
        August = 6,
        September = 7,
        Oktober = 8,
        November = 9,
        Dezember = 10
    }

    class Program
    {
        public static int Mod(int x, int m) // % Operator is bad with negative numbers See: https://stackoverflow.com/a/1082938
        {
            int r = x % m;
            return r < 0 ? r + m : r;
        }

        static void Main(string[] args)
        {
            bool keepOn = true;
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (!IstGueltigesDatum(input))
                {
                    Console.WriteLine("Einge erneut versuchen? (j/N)");
                    string retry = Console.ReadLine();
                    if (!retry.Equals("j"))
                    {
                        System.Environment.Exit(0);
                    }
                }
                else
                {
                    keepOn = false;
                }
            } while (keepOn);

            int[] date = ErmittleTagMonatJahr(input);

            Console.WriteLine(ErmittleWochentag(date[0], date[1], date[2]));
        }

        /// <summary>
        /// asdf
        /// </summary>
        /// <param name="datum">fgh</param>
        /// <returns>dfg</returns>
        public static int[] ErmittleTagMonatJahr(string datum)
        {
            if (!IstGueltigesDatum(datum))
            {
                return null;
            }

            string[] dateParts = datum.Split(".");
            int[] dateIntArray = new int[3];
            for (int i = 0; i < dateParts.Length; i++)
            {
                dateIntArray[i] = int.Parse(dateParts[i]);
            }

            return dateIntArray;
        }

        /// <summary>
        /// asdf
        /// </summary>
        /// <param name="datum">ku</param>
        /// <returns>rht</returns>
        public static bool IstGueltigesDatum(string datum)
        {
            return DateTime.TryParseExact(datum, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out _);
        }

        /// <summary>
        /// asdfss
        /// </summary>
        /// <param name="tag">gfj</param>
        /// <param name="monat">reh</param>
        /// <param name="jahr">hfgk</param>
        /// <returns>eht</returns>
        public static Wochentag ErmittleWochentag(int tag, int monat, int jahr)
        {
            int d = tag;
            int m = EvaluateM(monat);
            int y = EvaluateY(jahr, (MonatGregorianisch)monat);
            int c = EvaluateC(jahr, (MonatGregorianisch)monat);

            int x1 = (int)(2.6 * m - 0.2);
            int x2 = y / 4;
            int x3 = c / 4;
            int x4 = d + x1 + y + x2 + x3 - 2 * c;

            return (Wochentag)Mod(x4, 7);
        }

        private static int EvaluateM(int monat)
        {
            MonatGregorianisch mGregorianisch = (MonatGregorianisch)monat;
            string mGregorianischString = mGregorianisch.ToString();
            MonatJulianisch mJulianisch = (MonatJulianisch)Enum.Parse(typeof(MonatJulianisch), mGregorianischString);
            return (int)mJulianisch;
        }

        private static int EvaluateY(int jahr, MonatGregorianisch monat)
        {
            string yearString = jahr.ToString();
            string leastSignificantDigitsString = yearString.Substring(yearString.Length - 3);
            int leastSignificantDigits = int.Parse(leastSignificantDigitsString);

            if (monat == MonatGregorianisch.Januar || monat == MonatGregorianisch.Februar)
            {
                leastSignificantDigits--;

                if (leastSignificantDigits < 0)
                {
                    leastSignificantDigits = 99;
                }
            }

            return leastSignificantDigits;
        }

        private static int EvaluateC(int jahr, MonatGregorianisch monat)
        {
            if (monat == MonatGregorianisch.Januar || monat == MonatGregorianisch.Februar)
            {
                jahr--;
            }

            string yearString = jahr.ToString();
            string mostSignificantDigitsString = yearString.Substring(0, 2);
            int mostSignificantDigits = int.Parse(mostSignificantDigitsString);

            return mostSignificantDigits;
        }
    }
}
