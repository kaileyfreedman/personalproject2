using System;
using System.Collections.Generic;

namespace personalproject2
{
    class TestDisplayInfo
    {
        public static bool RunTest()
        {
            Console.WriteLine($"You should see a red F, I, G, H, and T");
            Program.DisplayInfo("fight", "brown");

            Console.WriteLine($"You should see a green A and a red S, T, I, R");
            Program.DisplayInfo("stair", "beach");

            Console.WriteLine($"You should see a green K and N and a red I, F, E");
            Program.DisplayInfo("knife", "known");

            Console.WriteLine($"You should see a green U, G, and H and a red L and A");
            Program.DisplayInfo("laugh", "cough");

            return false;
        }
    }
}