using System;
using System.Collections.Generic;

namespace _022_Binary_Tree_Zigzag_Level_Order_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a binary tree, return the zigzag level order traversal of its nodes' values. 
                (ie, from left to right, then right to left for the next level and alternate between).

                For example:
                Given binary tree [3,9,20,null,null,15,7],
                    3
                   / \
                  9  20
                    /  \
                   15   7
                return its zigzag level order traversal as:
                [
                    [3],
                    [20,9],
                    [15,7]
                ]
            */

            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var solution = new Solution();

            solution.ZigzagLevelOrder(root);
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
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            throw new NotImplementedException();
        }
    }
}
