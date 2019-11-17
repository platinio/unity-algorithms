using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAlgorithms
{
    public class LinkedListQueueTest : MonoBehaviour
    {
        private void Start()
        {
            LinkedListQueue<string> stringQueue = new LinkedListQueue<string>();
            stringQueue.Enqueue("Hi");
            stringQueue.Enqueue( "I" );
            stringQueue.Enqueue( "am" );
            stringQueue.Enqueue( "James Roman" );

            int size = stringQueue.Size();
            for (int n = 0; n < 100 ; n++)
            {
                Debug.Log( stringQueue.Dequeue() );
            }

        }
    }

}

