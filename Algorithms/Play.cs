using System;
using System.Collections.Generic;
using Algorithms.Helpers;

namespace Algorithms
{
	class Play
	{
		static void Main(string[] args)
		{
            BinarySearch();
            //BST();
			//BinaryTree();
			//BFS();
		}

        static void BinarySearch() {
            List<int> haystack = new List<int>();
            for (int i = 1; i < 1000000; i++) {
                haystack.Add(i);
            }

            int needle = 333333333;
            int idx = BinarySearchArr.Search(haystack.ToArray(), needle);

            Console.WriteLine("Value " + needle + " found at : " + idx);
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

            Console.WriteLine("Create Minimal BST.");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var balanced = bst.MinimalBST(arr);
            bst.PostOrder(balanced);
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

            Console.WriteLine("\nChecking if path between two nodes exists? " + b.PathExists(root, "Sofia", "Lisa"));

		}
	}
}