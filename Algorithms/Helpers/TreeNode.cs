using System;
namespace Algorithms.Helpers
{
	public class TreeNode
	{
		public int value;
		public TreeNode[] children;

		public TreeNode(int value, TreeNode[] children)
		{
			this.value = value;
			this.children = children;
		}
	}
}
