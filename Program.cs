using System;

namespace personalproject2
{
    class Program
    {
        static void Main(string[] args)
        {

        void GetRandomWord()
        {
            // Load a filed called words.txt
            // Store each line as a separate word in a list named words
            // Generate a random number between 0 and words.Count and store the result in a variable called ix
            // Return the word at position ix. (e.g. words[ix])
        }
        string GetGuess(string correctWord)
        {
            // Prompt the user to make a guess
            // Read input from the keyboard and store the results in a variable named guess
            // If guess is the correct length (the guess and random word should be the same length), return the guess.
            // Otherwise, display an error message and ask them to make another guess.
        }
        void DisplayInfo(string guess, string correct)
        {
            // Validate that the guess and correct word are the same length
            // If the lengths do not match, throw an exception
            // If they match, iterate through each character:
            // Use the DisplayCharInfo method to determine what color to print the character
        }
        void DisplayCharInfo(char guess, int pos, string correct)
        {
            // If the guess is in the correct position, select the color green.
            // If the guess is in the correct word but not correct position, select yellow.
            // If the guess is not in the correct word, select red.
            // Display the guess
            // Reset the color back to white before returning
        }    
}
