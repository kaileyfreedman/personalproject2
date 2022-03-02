using System;
using System.Collections.Generic;

namespace personalproject2
{
    class TestDisplayCharInfo
    {
        public static bool RunTest()
        {
            Program.DisplayCharInfo('a', 1, "chart");
            Console.WriteLine($"You should expect to see a yellow A");

            Program.DisplayCharInfo('e', 5, "frame");
            Console.WriteLine($"You should expect to see a green E");

            Program.DisplayCharInfo('p', 5, "train");
            Console.WriteLine($"You should expect to see a red P");

            return false;
        }
    }
}
