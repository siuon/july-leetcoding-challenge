using System;

namespace _018_Course_Schedule_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                There are a total of n courses you have to take, labeled from 0 to n-1.
                Some courses may have prerequisites, for example to take course 0 you have to first take course 1, 
                which is expressed as a pair: [0,1]
                Given the total number of courses and a list of prerequisite pairs, 
                return the ordering of courses you should take to finish all courses.
                There may be multiple correct orders, you just need to return one of them. If it is impossible to finish all courses, 
                return an empty array.

                Example 1:
                Input: 2, [[1,0]] 
                Output: [0,1]
                Explanation: There are a total of 2 courses to take. To take course 1 you should have finished   
                            course 0. So the correct course order is [0,1] .
            */

            var numCourses = 2;
            var prerequisites = new int[1][];
            prerequisites[0] = new int[] { 0, 1 };

            var solution = new Solution();

            solution.FindOrder(numCourses, prerequisites);
        }
    }

    public class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            throw new NotImplementedException();
        }
    }
}
