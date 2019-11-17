using UnityEngine;

namespace UnityAlgorithms
{
    public class ArrayStackTest : MonoBehaviour
    {
        
        private void Awake()
        {
            ArrayStack<string> arrayStack = new ArrayStack<string>(10);

            arrayStack.Push("Hola");
            arrayStack.Push("Hi");
            arrayStack.Push( "borra esto" );

            arrayStack.Pop();

            for (int n = 0; n < arrayStack.array.Length; n++)
            {
                Debug.Log( arrayStack.array[n] );
            }
            
        }
    }
}

