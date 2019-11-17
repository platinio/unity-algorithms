using UnityEngine;

namespace UnityAlgorithms
{
    public class ArrayQueueTest : MonoBehaviour
    {
        [SerializeField] private int testSize = 10;
        [SerializeField] private int testSize2 = 10;

        private void Awake()
        {
            ArrayQueue<int> arrayQueue = new ArrayQueue<int>(5);

            for (int n = 0; n < testSize; n++)
            {
                arrayQueue.Enqueue(n);
            }

            for (int n = 0; n < testSize2; n++)
            {
                arrayQueue.Dequeue();
            }

            arrayQueue.Print();
        }
    }

}

