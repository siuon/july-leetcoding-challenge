using System;

namespace _019_Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given two binary strings, return their sum (also a binary string).

                The input strings are both non-empty and contains only characters 1 or 0.

                Example 1:

                Input: a = "11", b = "1"
                Output: "100"
            */

            var a = "11";
            var b = "1";

            var solution = new Solution();

            var result = solution.AddBinary(a, b);

            Console.WriteLine(result);

            Console.WriteLine(result == "100");
        }
    }

    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            throw new NotImplementedException();
        }
    }
}
