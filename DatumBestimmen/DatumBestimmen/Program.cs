using System;

namespace DatumBestimmen
{
    class Program
    {
        static void Main(string[] args)
        {
        }

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

        public static bool IstGueltigesDatum(string datum)
        {
            return DateTime.TryParseExact(datum, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out _);
        }
    }
}
