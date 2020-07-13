using System;
using System.Collections.Generic;

namespace _012_Reverse_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Reverse bits of a given 32 bits unsigned integer.

               Example 1:
               Input:  00000010100101000001111010011100
               Output: 00111001011110000010100101000000

               Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned integer 43261596, 
               so return 964176192 which its binary representation is 00111001011110000010100101000000.
            */

            uint n = 43261596;

            var solution = new Solution();

            Console.WriteLine(solution.reverseBits(n) == 964176192);
        }
    }

    public class Solution
    {
        public uint reverseBits(uint n)
        {
            var list = new List<uint>();

            for (int i = 0; i < 32; i++)
            {
                list.Add((uint)((n & (uint)(Math.Pow(2, i))) > 0 ? 1 : 0));
            }

            list.Reverse();

            uint sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += (uint)Math.Pow(2, i) * list[i];
            }

            return sum;
        }
    }
}
