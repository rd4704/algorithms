using System;
using Algorithms.Helpers;
                    
namespace Algorithms
{
    public class BinarySearchTree
    {
        public Node CreateBinarySearchTree()
        {
            Node left = new Node(3, new Node(2, null, null), new Node(4, null, null));
            Node right = new Node(8, new Node(6, null, null), new Node(10, null, null));

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
    }
}
