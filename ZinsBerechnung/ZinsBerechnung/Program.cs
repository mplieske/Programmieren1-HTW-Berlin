using System;

namespace ZinsBerechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teil 1
            Console.WriteLine("Bitte geben Sie das Startkapital in EUR ein:");
            string startkapitalInput = Console.ReadLine();

            double startkapital;
            if(!double.TryParse(startkapitalInput, out startkapital))
            {
                Console.WriteLine($"'{startkapitalInput}' ist nicht in double konvertierbar.");
                return;
            }
            startkapital = Convert.ToDouble(startkapitalInput);

            Console.WriteLine("Bitte geben Sie den Zinssatz in % ein:");
            string zinssatzInProzentInput = Console.ReadLine();

            double zinssatzInProzent;
            if(!double.TryParse(zinssatzInProzentInput, out zinssatzInProzent))
            {
                Console.WriteLine($"'{zinssatzInProzentInput}' ist nicht in double konvertierbar.");
                return;
            }
            zinssatzInProzent = Convert.ToDouble(zinssatzInProzentInput);

            Console.WriteLine("Bitte geben Sie die Laufzeit in Jahren ein:");
            string laufzeitInJahrenInput = Console.ReadLine();

            int laufzeitInJahren;
            if(!int.TryParse(laufzeitInJahrenInput, out laufzeitInJahren))
            {
                Console.WriteLine($"'{laufzeitInJahrenInput}' ist nicht in int konvertierbar.");
                return;
            }
            laufzeitInJahren = Convert.ToInt32(laufzeitInJahrenInput);

            double zinsgewinn = BerechneZinsGewinn(startkapital, zinssatzInProzent, laufzeitInJahren);
            Console.WriteLine($"Der Zinsgewinn beträgt '{zinsgewinn}'EUR.");
        }

        // Teil 2
        public static double BerechneZinsGewinn(double startKapital, double zinsSatzInProzent, int laufZeit)
        {
            double zinsSatzInDezimal = zinsSatzInProzent / 100;
            double multiplikator = Math.Pow(1 + zinsSatzInDezimal, laufZeit);
            double zinsgewinn = startKapital * (multiplikator - 1);

            return Math.Round(zinsgewinn, 2);
        }
    }
}
