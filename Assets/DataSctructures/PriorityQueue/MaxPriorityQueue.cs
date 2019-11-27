namespace UnityAlgorithms
{
    public class MaxPriorityQueue <T>
    {
        private T[] array = null;
        private int n;

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

        }

        private void Swin(int k)
        {
            while (k > 1 && k < k / 2)
            {

            }

        }

        private static void Swap<T>(T[] array, int indexA, int indexB)
        {
            T valueA = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = valueA;
        }

    }
}

