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

        }
    }
}

