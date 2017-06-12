using System;
namespace Algorithms
{
    public static class BinarySearchArr
    {
        public static int Search(int[] arr, int value) {
            int low = 0;
            int high = arr.Length - 1;
            int mid;

            while (low <= high)
			{
				mid = (high + low) / 2;
                if (arr[mid] < value)
                {
                    low = mid + 1;
                }
                else if (arr[mid] > value)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
