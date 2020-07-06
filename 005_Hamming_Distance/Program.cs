using System;

namespace _005_Hamming_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
               Given two integers x and y, calculate the Hamming distance.
   
               Note:
                           31
               0 ≤ x, y < 2
   
               Example:
               Input: x = 1, y = 4

               Output: 2

               Explanation:
               1   (0 0 0 1)
               4   (0 1 0 0)
                      ↑   ↑

               The above arrows point to positions where the corresponding bits are different.
            */

            var x = 1;
            var y = 4;

            var solution = new Solution();

            Console.WriteLine(solution.HammingDistance(x, y) == 2);
        }
    }

    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
