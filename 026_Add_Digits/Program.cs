using System.Collections.Specialized;
using System;

namespace _026_Add_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.

                Example:
                Input: 38
                Output: 2 

                Explanation: The process is like: 3 + 8 = 11, 1 + 1 = 2. 
                             Since 2 has only one digit, return it.

                Follow up:
                Could you do it without any loop/recursion in O(1) runtime?
            */

            var num = 38;

            var solution = new Solution();

            Console.WriteLine(solution.AddDigits(num) == 2);
        }
    }

    public class Solution
    {
        public int AddDigits(int num)
        {
            throw new NotImplementedException();
        }
    }
}
