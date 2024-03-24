using System;
using System.Collections.Generic;

namespace Algostruct.Questions.LeetCode
{
    public class BinaryTreeLevelOrderTraversal
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return Array.Empty<IList<int>>();

            List<IList<int>> tree = new();
            AddInternal(0, tree, root);

            return tree;
        }

        static void AddInternal(int depth, List<IList<int>> listOfNodes, TreeNode node)
        {
            if (node == null)
                return;

            if (listOfNodes.Count <= depth)
                listOfNodes.Add(new List<int>());

            var depthList = listOfNodes[depth];
            depthList.Add(node.val);

            AddInternal(depth + 1, listOfNodes, node.left);
            AddInternal(depth + 1, listOfNodes, node.right);
        }
    }

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
}
