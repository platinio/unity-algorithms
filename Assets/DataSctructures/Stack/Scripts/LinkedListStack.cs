
namespace UnityAlgorithms
{
    public class LinkedListStack<T>
    {
        private Node<T> first = null;

        public void Push(T item)
        {
           
            Node<T> newFirst = new Node<T>();
            newFirst.item = item;

            if (IsEmpty())
            {
                first = newFirst;
                return;
            }

            newFirst.nextNode = first;
            first = newFirst;
            
        }

        public T Pop()
        {
            if (IsEmpty())
                return default;

            T item = first.item;
            first = first.nextNode;

            return item;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public int Size()
        {
            if (first == null)
            {
                return 0;
            }


            int size = 1;
            Node<T> node = first;

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

