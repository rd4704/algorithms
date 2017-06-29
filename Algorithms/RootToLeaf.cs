using System;

namespace Algorithms
{
	public class RootToLeaf
	{
		class Node
		{
			public int cost;
			public Node[] children;
			public Node parent;
		}

		static int GetCheapestCost(Node rootNode)
		{
            if (rootNode == null) {
                return 0;
            }

			if (rootNode.children.Length == 0)
			{
				return rootNode.cost;
			}

            int minSalePath = int.MaxValue;

			foreach (Node node in rootNode.children)
			{
				var currentSum = GetCheapestCost(node);

                if (currentSum < minSalePath)
				{
					minSalePath = currentSum;
				}
			}

            return minSalePath + rootNode.cost;
	    }

		//static void Main(string[] args)
		//{
   //         Node root = new Node()
   //         {
   //             cost = 0,
   //             parent = null,
   //             children = new Node[2]
   //         };

   //         Node n2 = new Node()
   //         {
   //             cost = 5,
   //             parent = root
			//};

			//Node n22 = new Node()
			//{
			//	cost = 6,
			//	parent = root
			//};

   //         Node n1 = new Node()
   //         {
   //             cost = 3,
   //             parent = n2,
   //             children = null
   //         };
   //         Node n3 = new Node()
   //         {
   //             cost = 4,
   //             parent = n2,
   //             children = null
   //         };

			//Node n11 = new Node()
			//{
			//	cost = 1,
			//	parent = n22,
			//	children = null
			//};
			//Node n33 = new Node()
			//{
			//	cost = 2,
			//	parent = n22,
			//	children = null
			//};

        //    n2.children = new Node[2] { n1, n3 };
        //    n22.children = new Node[2] { n11, n33 };

        //    Console.WriteLine("Minimum Cost Path: {0}", GetCheapestCost(root));
        //}
	}
}
