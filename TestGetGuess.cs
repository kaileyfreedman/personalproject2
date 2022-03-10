using System;
using System.Collections.Generic;

namespace personalproject2
{
    class TestGetGuess
    {
        public static bool RunTest()
        {
            Console.WriteLine($"First type in axe. This should be an invalid guess. It will ask again.");
            Console.WriteLine($"Next type in flower. This should be an invalid guess. It will ask again.");
            Console.WriteLine($"Then type in apple. This should be a valid guess. By typing in apple, the method should return the guess.");
            string expected1 = "apple";
            string input1 = Program.GetGuess("apple");
            if (expected1 != input1)
            {
                Console.Error.WriteLine($"Expected 'apple' but was {input1}");
                return false;
            }


            Console.WriteLine($"First type in tree. This should be an invalid guess. It will ask again.");
            Console.WriteLine($"Next type in butterfly. This should be an invalid guess. It will ask again.");
            Console.WriteLine($"Then type in brown. This should be a valid guess. By typing in apple, the method should return the guess.");
            string expected2 = "brown";
            string input2 = Program.GetGuess("brown");
            if (expected2 != input2)
            {
                Console.Error.WriteLine($"Expected 'brown' but was {input2}");
                return false;
            }


            Console.WriteLine($"First type in tree. This should be an invalid guess. It will ask again.");
            Console.WriteLine($" Then type no letters and hit enter. This should be an invalid guess. It will ask again.");
            Console.WriteLine($"Next type in brown. This should be a valid guess. By typing in apple, the method should return the guess.");
            string expected3 = "happy";
            string input3 = Program.GetGuess("happy");
            if (expected3 != input3)
            {
                Console.Error.WriteLine($"Expected 'happy' but was {input3}");
                return false;
            }

            return true;

        }
    }
}
