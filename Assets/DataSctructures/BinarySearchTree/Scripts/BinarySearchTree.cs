using System;

namespace UnityAlgorithms
{
    public class BinarySearchTree <T1 , T2> where T1 : IComparable
    {
        public Tree<T1, T2> root;

        public void Insert(T1 key , T2 value)
        {
            root = Insert( root , key , value );
        }

        private Tree<T1 , T2> Insert(Tree<T1 , T2> tree , T1 key , T2 value)
        {
            if (tree == null)
                return new Tree<T1 , T2>(key , value);

            int comp = key.CompareTo( tree.key );

            if (comp < 0)
            {
                tree.left = Insert( tree.left, key, value );
            }
            else if (comp > 0)
            {
                tree.right = Insert( tree.right, key, value );
            }

            else
            {
                tree.value = value;
            }

            return tree;
        }        
    }

    public class Tree<T1 , T2> where T1 : IComparable
    {
        public Tree<T1 , T2> left;
        public Tree<T1 , T2> right;        
        public T1 key;
        public T2 value;
        public int count;

        public Tree(T1 key, T2 value)
        {
            this.key = key;
            this.value = value;
        }

    }

}

