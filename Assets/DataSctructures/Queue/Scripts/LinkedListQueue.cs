namespace UnityAlgorithms
{
    public class LinkedListQueue<T>
    {
        private Node<T> first = null;
        private Node<T> last = null;
    
        public int Count { get; private set; }

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

            Count++;

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

            Count--;

            return item;
        }      



        private class Node<T>
        {
            public T item;
            public Node<T> nextNode;
        }

    }

}

