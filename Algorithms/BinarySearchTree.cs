using System;
using System.Collections.Generic;
using Algorithms.Helpers;
                    
namespace Algorithms
{
    public class BinarySearchTree
    {
        public Node CreateBinarySearchTree()
        {
            Node left = new Node(3, new Node(2), new Node(4));
            Node right = new Node(8, new Node(6), new Node(10));

            return new Node(5, left, right);
        }

        public void InOrder(Node root) {
            if (root.left != null) {
                InOrder(root.left);
            }

            Console.WriteLine(root.data);

			if (root.right != null)
			{
				InOrder(root.right);
			}
		}

		public void PreOrder(Node root)
		{
			Console.WriteLine(root.data);

			if (root.left != null)
			{
				PreOrder(root.left);
			}

			if (root.right != null)
			{
				PreOrder(root.right);
			}
		}

		public void PostOrder(Node root)
		{
			if (root.left != null)
			{
				PostOrder(root.left);
			}

			if (root.right != null)
			{
				PostOrder(root.right);
			}

			Console.WriteLine(root.data);
		}

        public Node MinimalBST(int[] arr)
        {
            return CreateMinHeightBST(arr, 0, arr.Length - 1);
        }

        public Node CreateMinHeightBST(int[] arr, int start, int end)
        {
            if (end < start || arr.Length == 0 || arr == null) {
                return null;
            }

            int mid = (start + end) / 2;

            var node = new Node(arr[mid])
            {
                left = CreateMinHeightBST(arr, start, mid - 1),
                right = CreateMinHeightBST(arr, mid+1, arr.Length - 1)
            };

            return node;
        }

		// Iterative Inorder traversal
		public void IterativeInorder(Node root)
		{
			if (root == null)
			{
				return;
			}

			Node node = root.left;
			while (node != null)
			{
				Console.WriteLine(node.data);
				node = node.left;
			}

			Console.WriteLine(root.data);

			node = root.right;
			while (node != null)
			{
				Console.WriteLine(node.data);
				node = node.right;
			}
		}
    }
}
