using UnityEngine;

namespace UnityAlgorithms
{
    public class ShuffleTest : MonoBehaviour
    {
        public int arraySize = 10;

        private void Start()
        {
            int[] array = new int[arraySize];

            for (int n = 0; n < array.Length; n++)
            {
                array[n] = n;
            }

            Shuffling.Shuffle( array );
           
            for (int n = 0; n < array.Length; n++)
            {
                Debug.Log( array[n] );
            }

        }
    }

}

