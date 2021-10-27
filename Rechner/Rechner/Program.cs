using System;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumberString = FrageNachDaten("Bitte geben Sie die erste Ganzzahl ein:");
            string mathOperator = FrageNachDaten("Bitte geben Sie den Operator [+,-,*] ein:");
            string secondNumberString = FrageNachDaten("Bitte geben Sie die zweite Ganzzahl ein:");

            int firstNumber = ErmittleGanzzahl(firstNumberString);
            int secondNumber = ErmittleGanzzahl(secondNumberString);

            BerechneUndGebeErgebnisAus(firstNumber, secondNumber, mathOperator);
        }

        static string FrageNachDaten(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        static void BerechneUndGebeErgebnisAus(int firstNumber, int secondNumber, string mathOperator)
        {
            switch (mathOperator)
            {
                case "+":
                    Console.WriteLine("Die Summe von " + firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
                    break;

                case "-":
                    Console.WriteLine("Die Differenz von " + firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
                    break;

                case "*":
                    Console.WriteLine("Das Produkt von " + firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
                    break;

                default:
                    Console.WriteLine("Ich weiß nicht, was ich berechnen soll.");
                    break;
            }
        }

        static int ErmittleGanzzahl(string numberString)
        {
            return int.Parse(numberString);
        }
    }
}
