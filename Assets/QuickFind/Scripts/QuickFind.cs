
namespace UnityAlgorithms
{
    public class QuickFind 
    {
        private int[] array;

        public QuickFind(int size)
        {
            array = new int[size];

            for (int n = 0; n < size; n++)
            {
                array[n] = n;
            }
        }

        public bool IsConnected(int a , int b)
        {
            return array[a] == array[b];
        }

        public void CreateConnection(int a , int b)
        {
            int newConnection = a;
            int oldConnection = b;

            for (int n = 0; n < array.Length; n++)
            {
                if (array[n] == oldConnection)
                {
                    array[n] = newConnection;
                }
            }

        }

    }

}


