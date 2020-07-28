using System;

namespace _027_Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given inorder and postorder traversal of a tree, construct the binary tree.

                Note:
                You may assume that duplicates do not exist in the tree.

                For example, given
                inorder = [9,3,15,20,7]
                postorder = [9,15,7,20,3]
                
                Return the following binary tree:

                    3
                   / \
                  9  20
                    /  \
                   15   7
            */

            var inorder = new int[] { 9, 3, 15, 20, 7 };
            var postorder = new int[] { 9, 15, 7, 20, 3 };

            var solution = new Solution();

            var result = solution.BuildTree(inorder, postorder);
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
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            throw new NotImplementedException();
        }
    }
}
