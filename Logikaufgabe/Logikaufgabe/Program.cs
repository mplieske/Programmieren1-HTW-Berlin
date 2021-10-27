using System;

namespace Logikaufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie Ihren Vor- und Nachnamen ein:");
            string name = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie das Zeichen für den Rahmen ein:");
            string zeichen = Console.ReadLine();

            string message = "Hallo " + name + "!";
            GebeUmrahmteBegruessungAus(message, zeichen);
        }

		public static void GebeUmrahmteBegruessungAus(string message, string zeichen)
		{
			string rahmenBreit = "";
			for (int i = 0; i < message.Length + 4; i++)
			{
				rahmenBreit += zeichen;
			}

			string leerzeile = "";
			leerzeile += zeichen;
			for (int i = 0; i < message.Length + 2; i++)
			{
				leerzeile += " ";
			}
			leerzeile += zeichen;

			Console.WriteLine(rahmenBreit);
			Console.WriteLine(leerzeile);
			Console.WriteLine($"{zeichen} {message} {zeichen}");
			Console.WriteLine(leerzeile);
			Console.WriteLine(rahmenBreit);
		}
	}
}
