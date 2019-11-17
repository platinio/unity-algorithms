using UnityEngine;

namespace UnityAlgorithms
{
    public class LinkedListQueueTest : MonoBehaviour
    {
        private void Start()
        {
            LinkedListQueue<string> stringQueue = new LinkedListQueue<string>();
            stringQueue.Enqueue("Hi");
            stringQueue.Enqueue( "this" );
            stringQueue.Enqueue( "is" );
            stringQueue.Enqueue( "a" );
            stringQueue.Enqueue( "LinkednListQueue" );

            int size = stringQueue.Size();
            for (int n = 0; n < 100 ; n++)
            {
                Debug.Log( stringQueue.Dequeue() );
            }

        }
    }

}

