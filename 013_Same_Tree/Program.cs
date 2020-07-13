using System;

namespace _013__Same_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given two binary trees, write a function to check if they are the same or not.
               Two binary trees are considered the same if they are structurally identical and the nodes have the same value.
   
               Example 1:
               Input:     1         1
                         / \       / \
                        2   3     2   3
   
                       [1,2,3],   [1,2,3]
               Output: true
            */

            var p = new TreeNode(1);
            p.left = new TreeNode(2);
            p.right = new TreeNode(3);

            var q = new TreeNode(1);
            q.left = new TreeNode(2);
            q.right = new TreeNode(3);

            var solution = new Solution();

            Console.WriteLine(solution.IsSameTree(p, q));
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
        bool _same = true;

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            { return true; }

            if ((p == null && q != null) ||
                (p != null && q == null))
            {
                return false;
            }

            CompareTree(p, q);

            return _same;
        }

        private void CompareTree(TreeNode p, TreeNode q)
        {
            if (p.val != q.val)
            {
                _same = false;

                return;
            }

            if (p.left != null && q.left != null)
            {
                CompareTree(p.left, q.left);
            }

            if (p.right != null && q.right != null)
            {
                CompareTree(p.right, q.right);
            }

            if ((p.left != null && q.left == null) ||
                (p.left == null && q.left != null) ||
                (p.right != null && q.right == null) ||
                (p.right == null && q.right != null))
            {
                _same = false;

                return;
            }
        }
    }
}
