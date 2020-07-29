using System;

namespace _028_Task_Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                You are given a char array representing tasks CPU need to do. 
                It contains capital letters A to Z where each letter represents a different task. 
                Tasks could be done without the original order of the array. Each task is done in one unit of time. 
                For each unit of time, the CPU could complete either one task or just be idle.

                However, there is a non-negative integer n that represents the cooldown period between two same tasks 
                (the same letter in the array), that is that there must be at least n units of time between any two same tasks.

                You need to return the least number of units of times that the CPU will take to finish all the given tasks.

                Example 1:
                Input: tasks = ["A","A","A","B","B","B"], n = 2
                Output: 8

                Explanation: 
                A -> B -> idle -> A -> B -> idle -> A -> B
                There is at least 2 units of time between any two same tasks.

                Constraints:
                    The number of tasks is in the range [1, 10000].
                    The integer n is in the range [0, 100].
            */

            var tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' };
            var n = 2;

            var solution = new Solution();

            Console.WriteLine(solution.LeastInterval(tasks, n) == 8);
        }
    }

    public class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            throw new NotImplementedException();
        }
    }
}
