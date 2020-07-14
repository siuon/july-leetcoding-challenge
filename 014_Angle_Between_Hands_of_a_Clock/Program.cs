using System.Linq.Expressions;
using System;

namespace _014_Angle_Between_Hands_of_a_Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given two numbers, hour and minutes. Return the smaller angle (in degrees) formed between the hour and the minute hand.

                Example 1:

                Input: hour = 12, minutes = 30
                Output: 165
            */

            var hour = 12;
            var minutes = 30;

            var solution = new Solution();

            Console.WriteLine(solution.AngleClock(12, 30) == 165);
        }
    }

    public class Solution
    {
        public double AngleClock(int hour, int minutes)
        {
            var hourDegree = (hour % 12) * 30d;

            hourDegree += 30d / 60 * minutes;

            hourDegree = hourDegree == 360 ? 0 : hourDegree;

            var minuteDegree = 360d / 60 * minutes;

            var big = Math.Max(hourDegree, minuteDegree);
            var small = Math.Min(hourDegree, minuteDegree);

            var retDegree = big - small;

            return retDegree > 180 ? 360 - retDegree : retDegree;
        }
    }
}
