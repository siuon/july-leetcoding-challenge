using System.Linq;
using System;
using System.Collections.Generic;

namespace _011_Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a set of distinct integers, nums, return all possible subsets (the power set).
   
               Note: The solution set must not contain duplicate subsets.
   
               Example:
               Input: nums = [1,2,3]
               Output:
               [
                 [3],
                 [1],
                 [2],
                 [1,2,3],
                 [1,3],
                 [2,3],
                 [1,2],
                 []
               ]
            */

            var nums = new int[] { 1, 2, 3 };

            var solution = new Solution();

            solution.Subsets(nums);
        }
    }

    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            throw new NotImplementedException();
        }
    }
}
