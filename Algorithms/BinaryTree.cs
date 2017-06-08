using System;
using Algorithms.Helpers;

namespace Algorithms
{
    public class BinaryTree
    {
        public TreeNode root;

        public void PrepareTree() {
            TreeNode[] children = { 
                new TreeNode(1, null), 
                new TreeNode(3, new TreeNode[] { new TreeNode(10, null), new TreeNode(20, null) }), 
                new TreeNode(4, null),
                new TreeNode(20, null)
            };

            root = new TreeNode(2, children);
        }

        public void Traversal(TreeNode node) {
            Console.WriteLine("Children: " + node.value);
			if (node.children != null) {
				foreach (var child in node.children)
				{
					Traversal(child);
				}
            }
        }
    }
}
