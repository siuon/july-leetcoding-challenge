using System;

namespace _009_Maximum_Width_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a binary tree, write a function to get the maximum width of the given tree. 
               The width of a tree is the maximum width among all levels. 
               The binary tree has the same structure as a full binary tree, but some nodes are null.
   
               The width of one level is defined as the length between the end-nodes 
               (the leftmost and right most non-null nodes in the level, 
               where the null nodes between the end-nodes are also counted into the length calculation.
   
               Example 1:
   
               Input: 
   
                       1
                     /   \
                    3     2
                   / \     \  
                  5   3     9 
   
               Output: 4
               Explanation: The maximum width existing in the third level with the length 4 (5,3,null,9).
            */
        }
    }

    /*
     * Definition for a binary tree node.
     */
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public int WidthOfBinaryTree(TreeNode root)
        {

        }
    }
}
