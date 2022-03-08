using System;
using System.Collections.Generic;

namespace personalproject2
{
    class Program
    {
        public static void TestAll()
        {
            bool testGetRandomWord = TestGetRandomWord.RunTest();
            Console.WriteLine($"Test LoadFile(filename):{testGetRandomWord}");

            bool testGetGuess = TestGetGuess.RunTest();
            Console.WriteLine($"Test LoadFile(filename):{testGetGuess}");

            bool testDisplayInfo = TestDisplayInfo.RunTest();
            Console.WriteLine($"Test LoadFile(filename):{testDisplayInfo}");

            bool testDisplayCharInfo = TestDisplayCharInfo.RunTest();
            Console.WriteLine($"Test LoadFile(filename):{testDisplayCharInfo}");
        }

        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
        }

        /// <summary>
        /// Randomly generates a random word to be guessed.
        /// </summary>
        public static string GetRandomWord()
    
        {
            List<string> words = new List<string>();

            words.Add("ahead");
            words.Add("break");
            words.Add("alone");
            words.Add("glass");
            words.Add("chart");
            words.Add("horse");
            words.Add("giant");
            words.Add("focus");
            words.Add("moral");
            words.Add("night");
            words.Add("youth");
            words.Add("smile");
            words.Add("laugh");
            words.Add("valid");
            words.Add("truth");
            words.Add("stone");

            Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string randomWord = words[index];
            Console.WriteLine($"Your word in {randomWord}");
            
            return randomWord;
        }

        /// <summary>
        /// Asks the user to make a guess and validates the input before returning the guess.
        /// </summary>
        public static string GetGuess(string correctWord)
        {
            // Prompt the user to make a guess
            // Read input from the keyboard and store the results in a variable named guess
            // If guess is the correct length (the guess and random word should be the same length), return the guess.
            // Otherwise, display an error message and ask them to make another guess.
            string input;
            do
            {
                Console.Write("Enter a guess that is 5 letters long:");
                input = Console.ReadLine();

                if (input.Length != 5)
                {
                    Console.WriteLine("That guess is not 5 letters long.");
                }
            }
            while (input.Length != 5);
        
            return input;
        }

        /// <summary>
        /// Given a guess and the correct word to be guessed, displays the guess to the screen coloring each character based on its position and if it is in the correct word.
        /// </summary>
        public static void DisplayInfo(string guess, string correct)
        {
            // Validate that the guess and correct word are the same length
            // If the lengths do not match, throw an exception
            // If they match, iterate through each character:
            // Use the DisplayCharInfo method to determine what color to print the character
            if (guess.Length != correct.Length)
            {
            throw new Exception ("The guess is not the same length as the correct word.");
            }
            else
            {
                int ix = 0;
                foreach (char c in guess)
                {
                    DisplayCharInfo(c, ix, correct);
                    ix = ix+1; 
                }
            }
        }

        /// <summary>
        /// Given a guessed character, the position of that guess, and the correct word, select the correct color for the guess and write it to the console.
        /// </summary>
        public static void DisplayCharInfo(char guess, int pos, string correct)
        {
            // If the guess is in the correct position, select the color green.
            // If the guess is in the correct word but not correct position, select yellow.
            // If the guess is not in the correct word, select red.
            // Display the guess
            // Reset the color back to white before returning
        }
    }
}
