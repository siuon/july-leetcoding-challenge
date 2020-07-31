using System;
using System.Collections.Generic;

namespace _030_Word_Break_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, 
                add spaces in s to construct a sentence where each word is a valid dictionary word. Return all such possible sentences.

                Note:
                The same word in the dictionary may be reused multiple times in the segmentation.
                You may assume the dictionary does not contain duplicate words.

                Example 1:
                Input:
                s = "catsanddog"
                wordDict = ["cat", "cats", "and", "sand", "dog"]
                Output:
                [
                    "cats and dog",
                    "cat sand dog"
                ]
            */

            var s = "catsanddog";
            var wordDict = new List<string>() { "cat", "cats", "and", "sand", "dog" };

            var solution = new Solution();

            solution.WordBreak(s, wordDict);
        }
    }

    public class Solution
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            throw new NotImplementedException();
        }
    }
}
