using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAlgorithms
{
    public class SelectionSortTest : MonoBehaviour
    {
        [SerializeField] private int numbeROfEntries = 100;

        private void Awake()
        {
            List<int> collection = new List<int>(numbeROfEntries);

            for (int n = 0; n < numbeROfEntries; n++)
            {
                collection.Add( Random.Range(0 , numbeROfEntries));
            }

            
            SelectionSort.Sort<int>(collection);

            foreach (int item in collection)
                Debug.Log(item);

        }
    }

}

