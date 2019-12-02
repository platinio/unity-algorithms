using System;

namespace UnityAlgorithms
{
    public class MaxPriorityQueue <T> where T : IComparable
    {
        private T[] array = null;
        private int n = 0;
       

        public MaxPriorityQueue(int capacity)
        {
            array = new T[capacity];
        }

        public bool IsEmpty()
        {
            return n == 0;
        }

        public T DeleteMax()
        {
            T max = array[1];
            Swap( 1 , n--);
            Sink(1);
            array[n + 1] = default;
            return max;
        }

        public void Insert(T item)
        {
            array[++n] = item;
            Swin( n );
        }

        private void Swin(int k)
        {
            while (k > 1 && array[k/2].CompareTo( array[k]) == -1)
            {
                Swap( k , k / 2);
                k /= 2;
            }
        }

        private void Sink(int k)
        {
            while ( 2 * k <= n)
            {
                int j = 2 * k;
                if (j < n && array[j].CompareTo( array[j + 1] ) == -1)
                {
                    j++;
                }
                if (array[k].CompareTo( array[j] ) == 1)
                {
                    break;
                }

                Swap(k , j);
                k = j;

            }
        }

        private void Swap(int indexA, int indexB)
        {
            T valueA = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = valueA;
        }

    }
}

