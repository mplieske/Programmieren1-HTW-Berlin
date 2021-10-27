using System;

namespace Typen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teil 1
            // Deklaration / Initialisierung
            uint a0 = 100101101;
            float a1 = 1.0f;
            string a2 = "HTW Berlin";
            double a3 = 299.0 * 1e6;
            char a4 = '#';
            int a5 = -1234;
            byte a6 = 123;
            bool a7 = true;
            decimal a8 = -11111.1m;
            ushort a9 = 65535;

            // Ausgabe der Typen und Variablennamen über vorgegebene Methode
            GebeVariableAus(nameof(a0), a0);
            GebeVariableAus(nameof(a1), a1);
            GebeVariableAus(nameof(a2), a2);
            GebeVariableAus(nameof(a3), a3);
            GebeVariableAus(nameof(a4), a4);
            GebeVariableAus(nameof(a5), a5);
            GebeVariableAus(nameof(a6), a6);
            GebeVariableAus(nameof(a7), a7);
            GebeVariableAus(nameof(a8), a8);
            GebeVariableAus(nameof(a9), a9);

            // Teil 2
            // Deklaration / Initialisierung
            int b0 = 0;
            double b1 = 1.0;
            float b2 = 2f;
            string b3 = "3";

            // explizite Typumwandlung
            int c0 = b0 * Convert.ToInt32(b1);
            double c1 = Convert.ToDouble(b3);
            float c2 = Convert.ToSingle(b1) + b2;
            string c3 = Convert.ToString(b1);

            // Ausgabe
            GebeVariableAus(nameof(c0), c0);
            GebeVariableAus(nameof(c1), c1);
            GebeVariableAus(nameof(c2), c2);
            GebeVariableAus(nameof(c3), c3);

            // Teil 3
            // Testen der Methode
            int minutes = 90;
            double hours = InStunden(minutes);
            Console.WriteLine($"'{minutes}' minutes => '{hours}' h");
        }

        // Rechnet Minuten in Stunden um. Z.B. 90 min => 1.5 h
        public static double InStunden(int minuten)
        {
            // 1 Stunde hat 60 Minuten
            return minuten / 60d;
        }

        // Gibt Name und Type einer Variable auf der Kommandozeile aus
        static void GebeVariableAus(string name, object wert)
        {
            Console.WriteLine($"Die Variable {name} ist vom Typ {wert.GetType()} und hat den Wert { wert}");
        }
    }
}
