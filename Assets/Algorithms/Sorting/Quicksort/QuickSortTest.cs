using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAlgorithms
{
    public class QuickSortTest : MonoBehaviour
    {
        public List<int> array = new List<int>( );

        private void Awake()
        {
            

            Quicksort.Sort( array );


            for (int n = 0; n < array.Count; n++)
            {
                Debug.Log( array[n] );
            }

        }
    }

}

