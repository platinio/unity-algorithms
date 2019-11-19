using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAlgorithms
{
    public class DijkstrasTwoStackTest : MonoBehaviour
    {
        [SerializeField] private string sentence = null;

        private void Awake()
        {
            Debug.Log( DijkstrasTwoStack.Process(sentence) );
        }
    }
}

