using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Helpers;
using System.Linq;
using System.Diagnostics;

namespace Algorithms
{
    class Play
    {
        static void Main(string[] args)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //         PermutationCountCheck("The Quick Brown Fox jumps over a little lazy dog!", "The Quick Brown Fox jumps over a little lazy dog!");
            //stopwatch.Stop();
            //Console.WriteLine("Array Store - Time elapsed: {0}ms", stopwatch.ElapsedMilliseconds);

            //         stopwatch.Start();
            //         CheckPermutations("The Quick Brown Fox jumps over a little lazy dog!", "The Quick Brown Fox jumps over a little lazy dog!");
            //stopwatch.Stop();
            //Console.WriteLine("Array Store - Time elapsed: {0}ms", stopwatch.ElapsedMilliseconds);

            //         stopwatch.Start();
            //         Permutation("The Quick Brown Fox jumps over a little lazy dog!", "The Quick Brown Fox jumps over a little lazy dog!");
            //stopwatch.Stop();
            //Console.WriteLine("Array Store - Time elapsed: {0}ms", stopwatch.ElapsedMilliseconds);

            //BinarySearch();
            //BST();
            //BinaryTree();
            //BFS();

            LRU lru = new LRU(5);
            lru.Put(1, 1);
            lru.Put(2, 2);
            lru.Put(3, 3);
            lru.Put(4, 4);
            lru.Put(5, 5);

            Console.WriteLine("Val at 1: " + lru.Get(1));
            lru.Get(2);
            lru.Get(3);
            lru.Get(4);

            lru.Put(6, 10);

            Console.WriteLine("Val at 1: " + lru.Get(1));

        }

        #region Graphs / Trees

        static void BinarySearch()
        {
            List<int> haystack = new List<int>();
            for (int i = 1; i < 1000000; i++)
            {
                haystack.Add(i);
            }

            int needle = 3333;
            int idx = BinarySearchArr.Search(haystack.ToArray(), needle);

            Console.WriteLine("Value " + needle + " found at : " + idx);
        }

        static void BST()
        {
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

            Console.WriteLine("Iterative InOrder Traversal");
            bst.IterativeInorder(root);
        }

        static void BinaryTree()
        {
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

        static void BFS()
        {
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

        #endregion

        #region String / Array

        static void PermutationCountCheck(string s1, string s2) {
            if (s1.Length != s2.Length) {
                Console.WriteLine(false);
                return;
            }

            int[] charSet = new int[128];

            foreach(Char c in s1) {
                charSet[c]++;
			}

			foreach (Char c in s2)
			{
				charSet[c]--;
                if (charSet[c] < 0) {
					Console.WriteLine(false);
					return;
                }
			}

            if(charSet.Sum() != 0) {
                Console.WriteLine(false);
                return;
            }

            Console.WriteLine(true);
        }

        static void CheckPermutations(string str1, string str2) {
            int sum1, sum2 = 0;
            byte[] asciiBytes1 = Encoding.ASCII.GetBytes(str1);
            byte[] asciiBytes2 = Encoding.ASCII.GetBytes(str2);

            sum1 = asciiBytes1.Sum(x=>x);
            sum2 = asciiBytes2.Sum(x => x);

            Console.WriteLine(sum1 == sum2);
        }

        static void Permutation(string str1, string str2) {
            if (str1.Length != str2.Length) {
                Console.WriteLine(false);
                return;
            }

            Console.WriteLine(Sort(str1).Equals(Sort(str2)));
        }

        static string Sort(string str) {
			char[] content = str.ToCharArray();
			Array.Sort(content);
			return content.ToString();
        }

        #endregion
    }
}