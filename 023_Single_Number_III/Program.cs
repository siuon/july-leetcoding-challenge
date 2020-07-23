using System;
using System.Collections.Generic;

namespace _023_Single_Number_III
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given an array of numbers nums, in which exactly two elements appear only once and all the other elements appear exactly twice. 
                Find the two elements that appear only once.

                Example:
                Input:  [1,2,1,3,2,5]
                Output: [3,5]

                Note:
                    The order of the result is not important. So in the above example, [5, 3] is also correct.
                    Your algorithm should run in linear runtime complexity. Could you implement it using only constant space complexity?
            */

            var nums = new int[] { 1, 2, 1, 3, 2, 5 };

            var solution = new Solution();

            solution.SingleNumber(nums);
        }
    }

    public class Solution
    {
        public int[] SingleNumber(int[] nums)
        {
            var list = new Dictionary<int, int>();
            var returnValue = new List<int>();

            foreach (var num in nums)
            {
                if (list.ContainsKey(num))
                {
                    list[num] += 1;
                }
                else
                {
                    list.Add(num, 1);
                }
            }

            foreach (var item in list)
            {
                if (item.Value == 1)
                {
                    returnValue.Add(item.Key);
                }

                if (returnValue.Count > 1)
                {
                    break;
                }
            }

            return returnValue.ToArray();
        }
    }
}
