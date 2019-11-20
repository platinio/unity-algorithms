namespace UnityAlgorithms
{
    public class ArrayStack<T>
    {
        public T[] array = null;
        public int head = 0;

        public ArrayStack(int capacity)
        {
            array = new T[capacity];
        }

        public void Push(T item)
        {
            array[head++] = item;
        }

        public T Pop()
        {
            return array[--head];
        }

        public bool IsEmpty()
        {
            return head <= 0;
        }

    }
}

