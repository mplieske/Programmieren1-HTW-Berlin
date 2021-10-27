using System;

namespace Uebung2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Request user data
            Console.WriteLine("Bitte geben Sie Ihren Vornamen ein: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihren Nachnamen ein: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihre Straße ein: ");
            string street = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihre PLZ ein: ");
            string postalCode = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihre Stadt ein: ");
            string city = Console.ReadLine();

            // Print user data.
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(street);
            Console.WriteLine(postalCode + " " + city);
        }
    }
}
