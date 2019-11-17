using UnityEngine;
namespace UnityAlgorithms
{
    public class BinarySearch 
    {
        public int DoABinarySearch(int[] array , int key)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + ( high - low ) / 2;
                if (array[mid] > key)
                {
                    low = mid + 1;
                }
                else if (array[mid] < key)
                {
                    high = mid - 1;
                }
                else
                {
                    return array[mid];
                }
            }

            return -1;
        }
    }
}

