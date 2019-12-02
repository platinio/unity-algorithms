using System;

namespace UnityAlgorithms
{
    public class BinarySearchTree <T1 , T2> where T1 : IComparable
    {

        private Node root;

        public T2 Get(T1 key)
        {
            Node x = root;

            while (x != null)
            {
                int cmp = key.CompareTo(x.key);

                if (cmp < 0)
                {
                    x = x.left;
                }
                else if (cmp > 0)
                {
                    x = x.right;
                }
                else if (cmp == 0)
                {
                    return x.value;
                }                

            }

            return default;
        }

        public void Put(T1 key , T2 value)
        {
            root = Put(root , key , value);
        }


        private Node Put(Node x ,  T1 key , T2 value)
        {
            if (x == null)
                return new Node(key , value);

            int cmp = key.CompareTo( x.key );

            if (cmp < 0)
            {
                x.left = Put( x.left, key, value );
            }

            else if (cmp > 0)
            {
                x.right = Put( x.right, key, value );
            }
            else if (cmp == 0)
            {
                x.value = value;
            }

            return x;

        }


        private class Node
        {
            public T1 key;
            public T2 value;
            public Node left;
            public Node right;

            public Node(T1 key , T2 value)
            {
                this.key = key;
                this.value = value;
            }
           
        }
    }   

}

