using UnityEngine;
using System.Collections.Generic;

namespace UnityAlgorithms
{
    public class MergeSortTest : MonoBehaviour
    {
        public int arraySize = 10;

        private void Awake()
        {
            List<int> array = new List<int>(arraySize);

            for (int n = 0; n < arraySize; n++)
            {
                array.Add( Random.Range( 0, arraySize ));
            }
           
            List<int> sorted = MergeSortAlgorithm.MergeSort( array );

           
            for (int n = 0; n < sorted.Count; n++)
            {
                Debug.Log( sorted[n] );
            }

        }

    }
}

