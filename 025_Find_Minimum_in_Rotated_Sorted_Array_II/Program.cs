using System;

namespace _025_Find_Minimum_in_Rotated_Sorted_Array_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
                (i.e.,  [0,1,2,4,5,6,7] might become  [4,5,6,7,0,1,2]).
                Find the minimum element.
                The array may contain duplicates.

                Example 1:
                Input: [1,3,5]
                Output: 1

                Example 2:
                Input: [2,2,2,0,1]
                Output: 0

                Note:
                    This is a follow up problem to Find Minimum in Rotated Sorted Array.
                    Would allow duplicates affect the run-time complexity? How and why?
            */

            var nums = new int[] { 1, 3, 5 };

            var solution = new Solution();

            Console.WriteLine(solution.FindMin(nums) == 1);
        }
    }

    public class Solution
    {
        public int FindMin(int[] nums)
        {
            var min = int.MaxValue;

            foreach (var num in nums)
            {
                min = num < min ? num : min;
            }

            return min;
        }
    }
}
