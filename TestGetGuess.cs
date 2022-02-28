using System;
using System.Collections.Generic;

namespace personalproject2
{
    class TestGetGuess
    {
        public static bool RunTest()
        {
            
            Console.WriteLine("Expected: the output to contain 5 letters");
            Console.WriteLine("First type brown. You should see a red B, R, O, W, and N.");
            Console.WriteLine("Then type angry. You should see a green A and a red N, G, R, and Y.");
            Console.WriteLine("Then type alien. You should see a green A, a yellow E, and red L, I, and N.");
            Console.WriteLine("Then type axe. This should be an invalid guess. It will ask again to guess a word with 5 letters.");
            Console.WriteLine("Then type apple. This should be an valid guess.");

            Program.GetGuess("apple");
            return false;

            Console.WriteLine("Expected: the output to contain 5 letters");
            Console.WriteLine("First type happy. You should see a red H, A, P, P, and Y.");
            Console.WriteLine("Then type break. You should see a yellow E and a red B, R, A, and K.");
            Console.WriteLine("Then type broke. You should see a green O, K, E, and a red B and R.");
            Console.WriteLine("Then type no letters and hit enter. This should be an invalid guess. It will ask again to guess a word with 5 letters.");
            Console.WriteLine("Then type choke. This should be an valid guess.");

            Program.GetGuess("choke");
            return false;

            Console.WriteLine("Expected: the output to contain 5 letters");
            Console.WriteLine("First type stare. You should see a yellow T and E and a red S, A, and R.");
            Console.WriteLine("Then type treat. You should see a green T, a yellow E, and a red R, A, and T.");
            Console.WriteLine("Then type town. This should be an invalid guess. It will ask again to guess a word with 5 letters.");
            Console.WriteLine("Then type towel. This should be an valid guess.");

            Program.GetGuess("towel");
            return false;
        }
    }
}
