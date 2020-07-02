using System.Linq;
using System;
using System.Collections.Generic;

namespace _002_Binary_Tree_Level_Order_Traversal_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a binary tree, return the bottom-up level order traversal of its nodes' values. 
               (ie, from left to right, level by level from leaf to root).
   
               For example:
               Given binary tree [3,9,20,null,null,15,7],
                   3
                  / \
                 9  20
                   /  \
                  15   7
               return its bottom-up level order traversal as:
               [
                 [15, 7],
                 [9, 20],
                 [3]
               ]
            */

            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var solution = new Solution();

            solution.LevelOrderBottom(root);
        }
    }

    /*
      Definition for a binary tree node.
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
        private Dictionary<int, List<int>> _list;

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            _list = new Dictionary<int, List<int>>();

            GoPath(root, 0);

            List<IList<int>> returnList = new List<IList<int>>();

            foreach (var item in _list.OrderByDescending(it => it.Key))
            {
                returnList.Add(item.Value);
            }

            return returnList;
        }

        private void GoPath(TreeNode node, int level)
        {
            if (_list.ContainsKey(level))
            {
                _list[level].Add(node.val);
            }
            else
            {
                _list.Add(level, new List<int>() { node.val });
            }

            if (node.left != null)
            {
                GoPath(node.left, level + 1);
            }

            if (node.right != null)
            {
                GoPath(node.right, level + 1);
            }
        }
    }
}