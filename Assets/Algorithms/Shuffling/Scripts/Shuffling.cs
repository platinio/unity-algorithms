using System;
using System.Collections.Generic;

namespace UnityAlgorithms
{
    public class Shuffling
    {
        public static void Shuffle<T>(IList<T> collection) where T : IComparable
        {
            float[] list = new float[collection.Count];

            for (int n = 0; n < collection.Count; n++)
            {
                list[n] = UnityEngine.Random.value;              
            }

            //use a insertiong sort
            for (int n = 0; n < list.Length; n++)
            {
                for (int j = n; j > 0; j--)
                {
                    if (list[j].CompareTo( list[j - 1] ) == -1)
                    {
                        //when swaping the random array swap the collection to
                        Swap( list, j, j - 1 );
                        Swap( collection , j , j - 1 );
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

