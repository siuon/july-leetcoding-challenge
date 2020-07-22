using System;

namespace _021_Word_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a 2D board and a word, find if the word exists in the grid.

                The word can be constructed from letters of sequentially adjacent cell, 
                where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.

                Example:
                board =
                [
                    ['A','B','C','E'],
                    ['S','F','C','S'],
                    ['A','D','E','E']
                ]

                Given word = "ABCCED", return true.
                Given word = "SEE", return true.
                Given word = "ABCB", return false.
                
                Constraints:
                    board and word consists only of lowercase and uppercase English letters.
                    1 <= board.length <= 200
                    1 <= board[i].length <= 200
                    1 <= word.length <= 10^3
            */

            var board = new char[3][];
            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'C', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };

            var solution = new Solution();

            Console.WriteLine(solution.Exist(board, "ABCCED") == true);
            Console.WriteLine(solution.Exist(board, "SEE") == true);
            Console.WriteLine(solution.Exist(board, "ABCB") == false);
        }
    }

    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            throw new NotImplementedException();
        }
    }
}
