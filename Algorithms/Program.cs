using System;
using Algorithms.Helpers;

namespace Algorithms
{
	class Program
	{
		static void Main(string[] args)
		{
            BST();
			//BinaryTree();
			//BFS();
		}

        static void BST() {
            BinarySearchTree bst = new BinarySearchTree();
            Node root = bst.CreateBinarySearchTree();
            Console.WriteLine("InOrder BST Traversal");
			bst.InOrder(root);
			Console.WriteLine("PreOrder BST Traversal");
			bst.PreOrder(root);
			Console.WriteLine("PostOrder BST Traversal");
			bst.PostOrder(root);
        }

		static void BinaryTree() {
			BinaryTree bt = new BinaryTree();
			bt.PrepareTree();

			if (bt.root == null)
			{
				Console.WriteLine("Tree is Empty!");
			}
			else
			{
				Console.WriteLine("Tree has some data, let's traverse it!");

				bt.Traversal(bt.root);
			}
		}

		static void BFS() {
			BreadthFirstAlgorithm b = new BreadthFirstAlgorithm();
			Employee root = b.BuildEmployeeGraph();
			Console.WriteLine("Traverse Graph\n------");
			b.Traverse(root);

			Console.WriteLine("\nSearch in Graph\n------");
			Employee e = b.Search(root, "Eva");
			Console.WriteLine(e == null ? "Employee not found" : e.name);
			e = b.Search(root, "Brian");
			Console.WriteLine(e == null ? "Employee not found" : e.name);
			e = b.Search(root, "Soni");
			Console.WriteLine(e == null ? "Employee not found" : e.name);
		}
	}
}