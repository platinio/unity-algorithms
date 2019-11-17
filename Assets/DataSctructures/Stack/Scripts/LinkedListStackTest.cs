using UnityEngine;

namespace UnityAlgorithms
{
    public class LinkedListStackTest : MonoBehaviour
    {
        private void Awake()
        {
            LinkedListStack<string> linkedListStack = new LinkedListStack<string>();

            linkedListStack.Push("This");
            linkedListStack.Push( "is" );
            linkedListStack.Push( "a" );
            linkedListStack.Push( "LinkedListStack" );

            int size = linkedListStack.Size();

            for (int n = 0; n < size; n++)
            {
                Debug.Log( linkedListStack.Pop() );
            }
        }
    }
}

