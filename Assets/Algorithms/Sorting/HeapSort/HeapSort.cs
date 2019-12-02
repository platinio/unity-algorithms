using System;

namespace UnityAlgorithms
{
    public static class HeapSort
    {
        private static int n = 0;
        

        public static void Sort<T>(T[] array) where T : IComparable
        {
            n = array.Length;

            for (int k = n/2; k >= 1; k--)
            {
                Sink(array , k);
            }

            while (n > 1)
            {
                
                Swap(array , 1 , n);
                n--;
                Sink(array ,1);
            }

        }

        private static void Swin<T>(T[] array , int k ) where T : IComparable
        {
            while (k > 1 && array[k/2].CompareTo( array[k] ) == -1 )
            {
                Swap( array , k , k / 2 );
                k /= 2;
            }
        }

        private static void Sink<T>(T[] array , int k ) where T  : IComparable
        {
            while ( k * 2 <= n  )
            {
                int j = k * 2;

                if (j < n && array[j].CompareTo( array[j + 1] ) == -1) j++;

                if (array[k].CompareTo( array[j] ) == 1)
                {
                    break;
                }

                Swap<T>( array, k, j );
                k = j;
            }
        }

        private static void Swap<T>(T[] array , int indexA, int indexB)
        {
            T valueA = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = valueA;
        }

    }
}

