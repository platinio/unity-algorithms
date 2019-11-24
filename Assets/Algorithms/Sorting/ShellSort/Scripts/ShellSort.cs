using System;
using System.Collections.Generic;

namespace UnityAlgorithms
{
    public class ShellSort 
    {
        public static void Sort<T>(IList<T> collection) where T : IComparable
        {
           
            int h = 1;

            while ( h < collection.Count / 3)
            {
                h = 3 * h + 1;
            }

            while(h >= 1)
            {
                for (int n = h; n < collection.Count; n++)
                {
                    for (int j = n; j >= h; j-= h)
                    {
                        if (collection[j].CompareTo( collection[j - h] ) == -1)
                        {
                            Swap( collection, j, j - h );
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                h = h / 3;

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

