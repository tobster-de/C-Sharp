using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App
{
    
    class IndicesAndRanges
    {
        public static void Do()
        {
            var words = new string[]
                        {
                            // index from start    index from end
                            "The",    // 0                   ^9
                            "quick",  // 1                   ^8
                            "brown",  // 2                   ^7
                            "fox",    // 3                   ^6
                            "jumped", // 4                   ^5
                            "over",   // 5                   ^4
                            "the",    // 6                   ^3
                            "lazy",   // 7                   ^2
                            "dog"     // 8                   ^1
                        };            // 9 (or words.Length) ^0

            Console.WriteLine($"The last word is {words[^1]}");
            
            string[] quickBrownFox = words.AsSpan()[1..4].ToArray();
            
            Console.WriteLine(string.Join(",", quickBrownFox));
        }

    }
    
}
