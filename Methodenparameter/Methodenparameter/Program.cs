using System;

namespace Methodenparameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;
            GetCurrentDate(out day, out month, out year);
            Console.WriteLine($"heute: {day}.{month}.{year}");

            string textFoo = "albatross";
            string textBar = "Peter";
            Console.WriteLine($"textFoo: '{textFoo}', textBar: '{textBar}'");
            Sort(ref textFoo, ref textBar);
            Console.WriteLine($"textFoo: '{textFoo}', textBar: '{textBar}'");
            Sort(ref textBar, ref textFoo);
            Console.WriteLine($"textFoo: '{textFoo}', textBar: '{textBar}'");
        }

        /// <summary>
        /// Puts the current date into parameters
        /// </summary>
        /// <param name="day">variable to insert todays day into</param>
        /// <param name="month">variable to insert todays month into</param>
        /// <param name="year">variable to insert todays year into</param>
        public static void GetCurrentDate(out int day, out int month, out int year)
        {
            DateTime dateTime = DateTime.Now;
            day = dateTime.Day;
            month = dateTime.Month;
            year = dateTime.Year;
        }

        /// <summary>
        /// Sorts Strings. Afterwards text1 contains lexically smaller string and text2 the bigger one.
        /// </summary>
        /// <param name="text1">Variable to insert smaller of the two texts.</param>
        /// <param name="text2">Variable to insert bigger of the two texts.</param>
        /// <returns>false if at least one of the parameters is null or empty. true otherwise</returns>
        public static bool Sort(ref string text1, ref string text2)
        {
            if (String.IsNullOrEmpty(text1) || String.IsNullOrEmpty(text2))
            {
                return false;
            }

            if (text1.CompareTo(text2) > 0)
            {
                string buffer = text2;
                text2 = text1;
                text1 = buffer;
            }

            return true;
        }
    }
}
