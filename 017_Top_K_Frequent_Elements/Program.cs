using System.Linq;
using System.Collections.Generic;
using System;

namespace _017_Top_K_Frequent_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a non-empty array of integers, return the k most frequent elements.

                Example 1:
                Input: nums = [1,1,1,2,2,3], k = 2
                Output: [1,2]

                Note:

                You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
                Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
                It's guaranteed that the answer is unique, in other words the set of the top k frequent elements is unique.
                You can return the answer in any order.
            */

            var nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var k = 2;

            var solution = new Solution();

            solution.TopKFrequent(nums, k);
        }
    }

    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var list = new Dictionary<int, int>();
            var returnList = new HashSet<int>();

            foreach (var num in nums)
            {
                if (list.ContainsKey(num))
                {
                    list[num] = list[num] + 1;
                }
                else
                {
                    list.Add(num, 1);
                }
            }

            var temp = list.OrderByDescending(it => it.Value).Select(it => it.Key);

            return temp.Take(k).ToArray();
        }
    }
}
