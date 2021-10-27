using System;

namespace BinaerAusgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teil 1
            // Ausgabe der Aufforderung + einlesen der Eingabe
            Console.WriteLine("Bitte geben Sie eine Zahl zwischen 0 und 255 ein:");
            string input = Console.ReadLine();

            // Prüfen auf Konvertierbarkeit
            byte zahl;
            if(!byte.TryParse(input, out zahl))
            {
                // Ausgabe des Fehlers und schließen der Applikation bei Fehler.
                Console.WriteLine($"'{input}' ist keine Zahl zwischen 0 und 255.");
                return;
            }

            // Konvertieren der Zahl
            zahl = Convert.ToByte(input);

            // Teil 2
            string binaryString = Byte2Binary(zahl);
            Console.WriteLine($"'{zahl}' is '{binaryString}' in binary.");

            // Teil 3
            string hexString = Byte2Hexadecimal(zahl);
            Console.WriteLine($"'{zahl}' is '{hexString}' in hexadecimal.");
        }

        // Umsetzung des Programmablaufplans (Teil 2)
        public static string Byte2Binary(byte number)
        {
            int i = 0;
            int testValue = 1;
            string result = "";

            while(i < 8)
            {
                if((number & testValue) != 0)
                {
                    result = "1" + result;
                }
                else
                {
                    result = "0" + result;
                }

                testValue = 2 * testValue;
                i = i + 1;
            }

            return result;
        }

        // Teil 3
        public static string Byte2Hexadecimal(byte number)
        {
            // From: https://stackoverflow.com/a/624379
            return number.ToString("X2");
        }
    }
}
