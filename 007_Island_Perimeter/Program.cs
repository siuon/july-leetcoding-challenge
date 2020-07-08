using System;

namespace _007_Island_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               You are given a map in form of a two-dimensional integer grid where 1 represents land and 0 represents water.
   
               Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, 
               and there is exactly one island (i.e., one or more connected land cells).
   
               The island doesn't have "lakes" (water inside that isn't connected to the water around the island). 
               One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. 
               Determine the perimeter of the island.
   
               Example:
   
               Input:
               [
                   [0,1,0,0],
                   [1,1,1,0],
                   [0,1,0,0],
                   [1,1,0,0]
               ]
   
               Output: 16
   
               Explanation: The perimeter is the 16 yellow stripes in the image below:

               
            */

            var grid = new int[4][];
            grid[0] = new int[] { 0, 1, 0, 0 };
            grid[1] = new int[] { 1, 1, 1, 0 };
            grid[2] = new int[] { 0, 1, 0, 0 };
            grid[3] = new int[] { 1, 1, 0, 0 };

            var solution = new Solution();

            Console.WriteLine(solution.IslandPerimeter(grid) == 16);
        }
    }

    public class Solution
    {
        public int IslandPerimeter(int[][] grid)
        {
            throw new NotImplementedException();
        }
    }
}
