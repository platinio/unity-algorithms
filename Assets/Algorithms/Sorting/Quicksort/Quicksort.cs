using System;
using System.Collections.Generic;

namespace UnityAlgorithms
{
    public static class Quicksort 
    {

        public static void Sort<T>(IList<T> collection) where T : IComparable
        {
            Shuffling.Shuffle(collection);
            Sort(collection , 0 , collection.Count - 1);
        }

        private static void Sort<T>(IList<T> collection , int low , int high) where T : IComparable
        {
            if (high <= low)
                return;

            
            int j = Partition( collection , low , high );
            
            Sort(collection , low , j - 1);
            Sort(collection , j + 1 , high);

            
        }

        private static int Partition<T>( IList<T> collection , int low , int high) where T : IComparable
        {
            int i = low;
            int j = high + 1;

            while (true)
            {
                while (collection[++i].CompareTo( collection[low] ) == -1)
                {
                    if (i == high)
                    {
                        break;
                    }
                }

                while (collection[low].CompareTo( collection[--j] ) == -1)
                {
                    if (j == low)
                    {
                        break;
                    }
                }

                if (i >= j)
                {
                    break;
                }

                Swap(collection , i , j);

            }

            Swap(collection , low , j);
            return j;

        }

        private static void Swap<T>(IList<T> collection, int indexA, int indexB)
        {
            T valueA = collection[indexA];
            collection[indexA] = collection[indexB];
            collection[indexB] = valueA;
        }
    }
}

