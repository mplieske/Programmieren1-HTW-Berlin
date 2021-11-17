using System;

namespace Textanalyse
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "123 123 12345 ist eine zahl 1245";
            int numbersInString = ZaehleZahlen(testString);
            Console.WriteLine($"'{numbersInString}' is the number of numbers in '{testString}'");

            string testString2 = "ajahagafbbbbb            ";
            char mostOccurredChar = ErmittleHaeufigstenBuchstaben(testString2);
            Console.WriteLine($"'{mostOccurredChar}' is the char with most occurances in '{testString2}'.");
        }

        /// <summary>
        /// Teil 1:
        /// Zählt die anzahl an Zahlen in einem String s.
        /// "123 123 foo 12 bar foobar 789" hat 4 Zahlen.
        /// </summary>
        /// <param name="s">String in welchem alle Zahlen gezählt werden soll.</param>
        /// <returns>Anzahl an zahlen im String</returns>
        public static int ZaehleZahlen(string s)
        {
            bool isNumber = false;
            bool isNumberBuffer = false;

            int numberCounter = 0;

            foreach (char character in s)
            {
                isNumber = Char.IsDigit(character);

                if (isNumber && !isNumberBuffer)
                {
                    numberCounter++;
                }

                isNumberBuffer = isNumber;
            }

            return numberCounter;
        }

        /// <summary>
        /// Teil 2:
        /// Calculates the most occuring letter in a string.
        /// </summary>
        /// <param name="s">The string to be used for calculation.</param>
        /// <returns>Character representing the most occurred letter.</returns>
        public static char ErmittleHaeufigstenBuchstaben(string s)
        {
            int[] peter = new int[255];
            for (int i = 0; i < peter.Length; i++)
            {
                peter[i] = 0;
            }

            char[] sCString = s.ToCharArray();
            for (int i = 0; i < sCString.Length; i++)
            {
                char currentCharacter = sCString[i];
                int ascii = (int)currentCharacter;
                peter[ascii] = peter[ascii] + 1;
            }

            int indexWithHighestValue = 0;
            for (int i = 0; i < peter.Length; i++)
            {
                if (!Char.IsLetter((char)i))
                {
                    continue;
                }

                if (peter[i] > peter[indexWithHighestValue])
                {
                    indexWithHighestValue = i;
                }
            }

            return (char)indexWithHighestValue;
        }
    }
}
