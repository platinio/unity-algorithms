using UnityEngine;

namespace UnityAlgorithms
{
    [System.Serializable]
    public class QuickUnion 
    {
        [SerializeField] private int[] array = null;

        public QuickUnion(int size)
        {
            array = new int[size];

            for (int n = 0; n < size; n++)
            {
                array[n] = n;
            }
        }

        private int GetRoot(int n)
        {
            while (n != array[n])
            {
                n = array[n];
            }

            return n;
        }

        public bool IsConnected(int a , int b)
        {
            return GetRoot( a ) == GetRoot( b );
        }

        public void CreateConnection(int a , int b)
        {
            int rootA = GetRoot(a);
            int rootB = GetRoot(b);

            array[rootA] = rootB;
        }


    }
}

