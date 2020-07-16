using System;
using System.Collections.Generic;

namespace _015_Reverse_Words_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given an input string, reverse the string word by word.

                Example 1:
                Input: "the sky is blue"
                Output: "blue is sky the"

                Note:
                  A word is defined as a sequence of non-space characters.
                  Input string may contain leading or trailing spaces. However, 
                    your reversed string should not contain leading or trailing spaces.
                  You need to reduce multiple spaces between two words to a single space in the reversed string.

                Follow up:
                For C programmers, try to solve it in-place in O(1) extra space.
            */

            var s = "the sky is blue";

            var solution = new Solution();

            var expect = "blue is sky the";

            var output = solution.ReverseWords(s);

            Console.WriteLine(s);
            Console.WriteLine(output);

            Console.WriteLine(output == expect);
        }
    }

    public class Solution
    {
        public string ReverseWords(string s)
        {
            throw new NotImplementedException();
        }
    }
}
