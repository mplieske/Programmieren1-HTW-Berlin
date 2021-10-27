using System;

namespace AnweisungenUmsetzen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie Ihren Vor- und Nachnamen ein:");
            string name = Console.ReadLine();

            string greeting = ErmittleBegruessung(DateTime.Now.Hour);
            Console.WriteLine($"{greeting} {name}!");
        }

        public static string ErmittleBegruessung(int stunde)
        {
            if (stunde >= 5 && stunde < 11)
            {
                return "Guten Morgen";
            }

            if (stunde >= 11 && stunde < 17)
            {
                return "Guten Tag";
            }

            if (stunde >= 17 && stunde < 23)
            {
                return "Guten Abend";
            }

            if ((stunde >= 23 && stunde < 24) || (stunde >= 0 && stunde < 5))
            {
                return "Gute Nacht";
            }

            return "";
        }
    }
}
