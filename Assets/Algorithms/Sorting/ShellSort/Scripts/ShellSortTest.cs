using UnityEngine;

namespace UnityAlgorithms
{
    public class ShellSortTest : MonoBehaviour
    {
        public int arraySize = 10;

        private void Awake()
        {
            int[] array = new int[arraySize];

            for (int n = 0; n < array.Length; n++)
            {
                array[n] = Random.Range(0 , arraySize);
            }

            ShellSort.Sort(array);

            for (int n = 0; n < array.Length; n++)
            {
                Debug.Log( array[n] );
            }

        }
    }
}
