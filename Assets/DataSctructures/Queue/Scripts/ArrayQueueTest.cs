using UnityEngine;

namespace UnityAlgorithms
{
    public class ArrayQueueTest : MonoBehaviour
    {
        [SerializeField] private int enqueueCount = 10;
        [SerializeField] private int dequeueCount = 10;

        private void Awake()
        {
            ArrayQueue<int> arrayQueue = new ArrayQueue<int>(5);

            for (int n = 0; n < enqueueCount; n++)
            {
                arrayQueue.Enqueue(n);
            }

            for (int n = 0; n < dequeueCount; n++)
            {
                arrayQueue.Dequeue();
            }

            arrayQueue.Print();
        }
    }

}

