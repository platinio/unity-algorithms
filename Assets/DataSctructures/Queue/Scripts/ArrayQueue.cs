using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace UnityAlgorithms
{
    public class ArrayQueue <T> : IEnumerable<T>
    {
        private T[] array = null;
        private int first = 0;
        private int last = 0;
        private int defaultCapacity = 10;
        private int initialSize = 0;

        public int Count { get { return last - first;  } }
        public bool IsEmpty { get { return Count == 0; } }

        public ArrayQueue()
        {
            Initialize(defaultCapacity);
        }

        public ArrayQueue(int capacity)
        {
            Initialize(capacity);
        }

        private void Initialize(int capacity)
        {
            array = new T[capacity];
            initialSize = capacity;
        }

        public void Enqueue(T item)
        {
            if (Count == array.Length)
            {
                IncreaseSize();
            }            

            array[last++] = item;
        }

        private void IncreaseSize()
        {
            T[] newArray = new T[array.Length * 2];
            int counter = 0;

            for (int n = first; n < last; n++)
            {
                newArray[counter++] = array[n];
            }
            
            array = newArray;
            first = 0;
            last = counter;
        }

        public T Dequeue()
        {
            if ( IsEmpty )
            {
                return default;
            }

            T item = array[first++];

            if (array.Length / 2 > initialSize && Count <= array.Length / 4)
            {
                DecreseSize();
            }

            return item;
        }

       

        private void DecreseSize()
        {
            T[] newArray = new T[array.Length / 2];
            int counter = 0;

            for (int n = first; n < last; n++)
            {
                newArray[counter++] = array[n];
            }

            array = newArray;
            first = 0;
            last = counter;

        }

        public void PrintAll()
        {
            for (int n = 0 ; n < array.Length; n++)
            {
                Print(n);
            }
        }

        public void Print()
        {
            foreach (T item in this)
            {
                Print(n);
            }
        }

        private void Print(int index)
        {
            Debug.Log( "Array[" + index + "] = " + array[index] );
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int n = first; n < last; n++)
            {
                yield return array[n];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}

