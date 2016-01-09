using System;

namespace Alex.Common
{
    public class InputChecker
    {
        public static long AskCheckAndReAskForLongInput(string screenPromt)
        {
            string userInput = "";
            long correctInput = 0;
            while (!Int64.TryParse(userInput, out correctInput))
            {
                Console.WriteLine(screenPromt);
                userInput = Console.ReadLine();
            }

            return correctInput;
        }

        public static long AskCheckAndReAskForLongInput(string screenPromt, int minValue)
        {
            string userInput = "";
            long correctInput = 0;
            while (!Int64.TryParse(userInput, out correctInput) || correctInput < minValue)
            {
                Console.WriteLine(screenPromt);
                userInput = Console.ReadLine();
            }

            return correctInput;
        }

        public static long AskCheckAndReAskForLongInput(string screenPromt, int minValue, int maxValue)
        {
            string userInput = "";
            long correctInput = 0;
            while (!Int64.TryParse(userInput, out correctInput) || correctInput < minValue || correctInput > maxValue)
            {
                Console.WriteLine(screenPromt);
                userInput = Console.ReadLine();
            }

            return correctInput;
        }

        public static int AskCheckAndReAskForIntegerInput(string screenPromt)
        {
            string userInput = "";
            int correctInput = 0;
            while (!Int32.TryParse(userInput, out correctInput))
            {
                Console.WriteLine(screenPromt);
                userInput = Console.ReadLine();
            }

            return correctInput;
        }

        public static int AskCheckAndReAskForIntegerInput(string screenPromt, int minValue)
        {
            string userInput = "";
            int correctInput = 0;
            while (!Int32.TryParse(userInput, out correctInput) || correctInput < minValue)
            {
                Console.WriteLine(screenPromt);
                userInput = Console.ReadLine();
            }

            return correctInput;
        }

        public static int AskCheckAndReAskForIntegerInput(string screenPromt, int minValue, int maxValue)
        {
            string userInput = "";
            int correctInput = 0;
            while (!Int32.TryParse(userInput, out correctInput) || correctInput < minValue || correctInput > maxValue)
            {
                Console.WriteLine(screenPromt);
                userInput = Console.ReadLine();
            }

            return correctInput;
        }
    }
}
