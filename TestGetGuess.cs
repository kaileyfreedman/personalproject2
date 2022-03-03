using System;
using System.Collections.Generic;

namespace personalproject2
{
    class TestGetGuess
    {
        public static bool RunTest()
        {
            // Feedback(jcollard 2022-03-03): Great job on this test! Double check the 
            // flow chart for this method. It doesn't actually display the result of the 
            // users value. It should only validate that the value entered is valid. For
            // example, if the user types ing "chocolate", it shouldn't be valid because the
            // word "chocolate" is too long.
            Console.WriteLine("First type brown. You should see a red B, R, O, W, and N.");
            string input = Program.GetGuess("apple");
            string expected = "brown";
            if (input != expected)
            {
                Console.Error.WriteLine($"Expected result to be 'brown' but was {input}");
                return false;

            }
            
            Console.WriteLine("Then type angry. You should see a green A and a red N, G, R, and Y.");
            string input2 = Program.GetGuess("apple");
            string expected2 = "angry";
            if (input != expected)
            {
                Console.Error.WriteLine($"Expected result to be 'angry' but was {input}");
                return false;

            }


            Console.WriteLine("Then type axe. This should be an invalid guess. It will ask again to guess a word with 5 letters.");
            string input3 = Program.GetGuess("apple");
            string expected3 = "axe";
            if (input != expected)

            {
                Console.Error.WriteLine($"Expected result to be 'axe' but was {input}");
                return false;

            }

            Console.WriteLine("Then type alien. You should see a green A, a yellow E, and red L, I, and N.");
            string input4 = Program.GetGuess("apple");
            string expected4 = "AlIEN";
            if (input != expected)
            {
                Console.Error.WriteLine($"Expected result to be 'alien' but was {input}");
                return false;

            }

            Console.WriteLine("Then type apple. All of the letter should be green.");
            string input5 = Program.GetGuess("apple");
            string expected5 = "APPLE";
            if (input != expected)
            {
                Console.Error.WriteLine($"Expected result to be 'apple' but was {input}");
                return false;

            }

            Console.WriteLine("First type start. You should see a green A, a yellow T, and a red S R T.");
            string input6 = Program.GetGuess("train");
            string expected7 = "start";
            if (input != expected)
            {
                Console.Error.WriteLine($"Expected result to be 'start' but was {input}");
                return false;

            }
            
            Console.WriteLine("Then type angry. You should see a green R and a red P, O, U, and D.");
            string input8 = Program.GetGuess("train");
            string expected9 = "proud";
            if (input != expected)
            {
                Console.Error.WriteLine($"Expected result to be 'proud' but was {input}");
                return false;

            }
            // return false;

            // Console.WriteLine("First type happy. You should see a red H, A, P, P, and Y.");
            // Console.WriteLine("Then type break. You should see a yellow E and a red B, R, A, and K.");
            // Console.WriteLine("Then type broke. You should see a green O, K, E, and a red B and R.");
            // Console.WriteLine("Then type no letters and hit enter. This should be an invalid guess. It will ask again to guess a word with 5 letters.");
            // Console.WriteLine("Then type choke. This should be an valid guess.");

            // Program.GetGuess("choke");
            // return false;

            // Console.WriteLine("First type stare. You should see a yellow T and E and a red S, A, and R.");
            // Console.WriteLine("Then type treat. You should see a green T, a yellow E, and a red R, A, and T.");
            // Console.WriteLine("Then type town. This should be an invalid guess. It will ask again to guess a word with 5 letters.");
            // Console.WriteLine("Then type towel. This should be an valid guess.");

            // Program.GetGuess("towel");
            // return false;
            
            return true;

        }
    }
}
