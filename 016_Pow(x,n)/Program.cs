using System;

namespace _016_Pow_x_n_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Implement pow(x, n), which calculates x raised to the power n (xn).

                Example 1:
                Input: 2.00000, 10
                Output: 1024.00000
            */

            var x = 2.00000;
            var n = 10;

            var output = 1024.00000;

            var solution = new Solution();

            Console.WriteLine(solution.MyPow(x, n) == output);
        }
    }

    public class Solution
    {
        public double MyPow(double x, int n)
        {
            throw new NotImplementedException();
        }
    }
}
