using UnityEngine;

namespace UnityAlgorithms
{
    public class LinkedListQueue<T>
    {
        private Node<T> first = null;
        private Node<T> last = null;

        public bool isEmpty()
        {
            return first == null;
        }

        public void Enqueue(T item)
        {
            Node<T> oldLast = last;

            last = new Node<T>();
            last.item = item;
            last.nextNode = null;

            if (isEmpty())
            {
                first = last;
            }
            else
            {
                oldLast.nextNode = last;
            }
            
        }

        public T Dequeue()
        {
            if (isEmpty())
            {
                return default(T);
            }

            T item = first.item;
            first = first.nextNode;

            if (isEmpty())
            {
                last = null;
            }

            return item;
        }

        public int Size()
        {
            if (first == null)
            {
                Debug.Log("first is null");
                return 0;
            }
                

            int size = 1;
            Node<T> node = first;

            if (node.nextNode == null)
            {
                Debug.Log("next node is null");
            }

            while (node.nextNode != null)
            {
                size++;
                node = node.nextNode;
            }

            return size;

        }



        private class Node<T>
        {
            public T item;
            public Node<T> nextNode;
        }

    }

}

