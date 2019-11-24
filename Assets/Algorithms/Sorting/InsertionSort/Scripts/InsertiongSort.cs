using System;
using System.Collections.Generic;


namespace UnityAlgorithms
{
    public class InsertiongSort
    {

        public static void Sort<T>(IList<T> collection) where T : IComparable
        {
            for (int n = 0; n < collection.Count; n++)
            {
                for (int j = n ; j > 0 ; j--)
                {
                    if (collection[j].CompareTo( collection[j - 1] ) == -1)
                    {
                        Swap<T>( collection, j, j - 1 );
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void Swap<T>(IList<T> collection, int indexA, int indexB)
        {
            T valueA = collection[indexA];
            collection[indexA] = collection[indexB];
            collection[indexB] = valueA;
        }


    }
}

