using System;

namespace AnweisungenUmsetzen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie Ihren Vor- und Nachnamen ein:");
            string name = Console.ReadLine();

            Console.WriteLine($"Hallo {name}!");
        }
    }
}
