using System.Linq;
using System;
using System.Collections.Generic;

namespace _006_Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a non-empty array of digits representing a non-negative integer, plus one to the integer.
               The digits are stored such that the most significant digit is at the head of the list, 
               and each element in the array contain a single digit.
               You may assume the integer does not contain any leading zero, except the number 0 itself.
   
               Example 1:
               Input: [1,2,3]
               Output: [1,2,4]
               Explanation: The array represents the integer 123.
            */

            var digits = new int[] { 9 };

            var solution = new Solution();

            var result = solution.PlusOne(digits);
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            throw new NotImplementedException():
        }
    }
}
