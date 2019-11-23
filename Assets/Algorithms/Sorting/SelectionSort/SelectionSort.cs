using System;
using System.Collections.Generic;

namespace UnityAlgorithms
{
    public static class SelectionSort 
    {
        private static int index = 0;

        public static void Sort<T>(IList<T> collection) where T : IComparable 
        {
            index = 0;

            for (int n = 0; n < collection.Count; n++)
            {
                int minValueIndex = GetMinValueIndex<T>( collection ,  n);

                if (minValueIndex != n)
                {
                    Swap<T>(collection , minValueIndex , n);
                }
            }

        }

        private static void Swap<T>(IList<T> collection , int indexA , int indexB)
        {
            T valueA = collection[indexA];
            collection[indexA] = collection[indexB];
            collection[indexB] = valueA;
        }

        private static int GetMinValueIndex<T>(IList<T> collection , int startingIndex) where T : IComparable
        {
            int minValueIndex = startingIndex;
            T minValue = collection[startingIndex];

            for (int n = startingIndex + 1; n < collection.Count; n++)
            {
                if (collection[n].CompareTo(minValue) == -1)
                {
                    minValue = collection[n];
                    minValueIndex = n;
                }
            }

            return minValueIndex;
        }


    }
}

