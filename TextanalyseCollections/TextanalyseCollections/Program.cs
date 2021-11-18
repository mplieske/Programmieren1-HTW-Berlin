using System;
using System.Collections.Generic;

namespace TextanalyseCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dict = ErmittleBuchstabenVerteilung("Heute ist ein schöner Tag.");

            foreach (char key in dict.Keys)
            {
                int value = dict.GetValueOrDefault(key);
                Console.WriteLine($"Key: '{key}' Value: '{value}'");
            }
            Console.WriteLine();

            char keyWithHighestValue = ErmittleMaxKey(dict);
            int highestValue = ErmittleMaxValue(dict);
            Console.WriteLine($"Key value pair with highest value: key='{keyWithHighestValue}' value='{highestValue}'");
        }

        /// <summary>
        /// Ermittelt den größten Value in dict.
        /// </summary>
        /// <param name="dict">Das Dictionary welches durchsucht werden soll.</param>
        /// <returns>int welcher den gößten Value in dict repräsentiert.</returns>
        public static int ErmittleMaxValue(Dictionary<char, int> dict)
        {
            char maxKey = ErmittleMaxKey(dict);
            return dict.GetValueOrDefault(maxKey);
        }

        /// <summary>
        /// Ermittelt den Key mit dem größten Value in dict.
        /// </summary>
        /// <param name="dict">Dictionary welches durchsucht werden soll.</param>
        /// <returns>char welcher den Key mit dem größten Value in dict repräsentiert.</returns>
        public static char ErmittleMaxKey(Dictionary<char, int> dict)
        {
            int highestValue = 0; // trivial und selbsterkärend
            char keyWithHighestValue = ' ';

            foreach (char key in dict.Keys)
            {
                int currentValue = dict.GetValueOrDefault(key);
                if (highestValue < currentValue)
                {
                    keyWithHighestValue = key;
                    highestValue = currentValue;
                }
            }

            return keyWithHighestValue;
        }

        /// <summary>
        /// Erstellt eine Tabelle mit allen Buchstaben und in einem string mit ihrer häufigkeit.
        /// </summary>
        /// <param name="s">String welcher ausgewertet werden soll.</param>
        /// <returns>Ein System.Collections.Generic.Dictionary<char, int> mit oben genannter häufigkeitstabelle.</returns>
        public static Dictionary<char, int> ErmittleBuchstabenVerteilung(string s)
        {
            Dictionary<char, int> commonnessOfCharsDictionary = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!Char.IsLetter(c)) // Fall kein Buchstabe überspringen
                {
                    continue;
                }

                if (!commonnessOfCharsDictionary.ContainsKey(c)) // Falls noch nicht vorhanden dem dict mit initialem Wert 1 hinzufügen
                {
                    commonnessOfCharsDictionary.Add(c, 1);
                    continue; // rest kann übersprungen werden
                }

                // falls nicht vorhanden soll aktueller wert ermittelt werden
                int valueForC = commonnessOfCharsDictionary.GetValueOrDefault(c);
                // altes KeyValuePair entfernt werden
                commonnessOfCharsDictionary.Remove(c);
                // neu mit altem Wert + 1 hinzugefügt werden
                commonnessOfCharsDictionary.Add(c, valueForC + 1);
            }

            return commonnessOfCharsDictionary;
        }
    }
}
