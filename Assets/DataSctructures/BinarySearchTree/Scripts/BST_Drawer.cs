using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UnityAlgorithms
{
    public class BST_Drawer : MonoBehaviour
    {
        [SerializeField] private TreeNode nodePrefab;
        [SerializeField] private float verticalSpace = 1.0f;
        [SerializeField] private float _horizontalSpace = 1.0f;
        [SerializeField] private float spaceIncreaseRate = 0.5f;
        [SerializeField] private int startingSize = 10;
        [SerializeField] private float deltaTime = 0.25f;
        [SerializeField] private TMP_InputField inputField = null;

        private BinarySearchTree<int, GameObject> bst = new BinarySearchTree<int, GameObject>();
        private float lastHorizontalSpaceValue;
        private Transform parent = null;
        private Coroutine renderCoroutine = null;

        private void Awake()
        {
            parent = new GameObject().transform;
            lastHorizontalSpaceValue = _horizontalSpace;

            
        }

        public void GenerateRandomTree()
        {
            _horizontalSpace = 6.0f;
            bst = new BinarySearchTree<int, GameObject>();

            for (int n = 0; n < startingSize; n++)
            {
                bst.Insert( Random.Range( 0, startingSize ), null );
            }

            RebuildBST();
        }

        private void RenderBST()
        {
            float x = transform.position.x;
            float y = transform.position.y;

            Vector3 position = new Vector3( x , y , transform.position.z );

            StopAllCoroutines();

            renderCoroutine = StartCoroutine( RenderTree( bst.root , position  , _horizontalSpace ) );
        }

        private IEnumerator RenderTree(Tree<int , GameObject> tree , Vector3 position , float horizontalSpace)
        {

            TreeNode node = CreateTreeNode(tree , position);
            
            position.y -= verticalSpace;
            horizontalSpace -= horizontalSpace * spaceIncreaseRate;

            if (horizontalSpace <= 0.04)
            {
                _horizontalSpace *= 1.25f;
                RebuildBST();
                yield break;
            }

            else
            {
                yield return new WaitForSeconds( deltaTime );

                if (tree.left != null)
                {
                    Vector3 leftPosition = position + ( Vector3.left * horizontalSpace );
                    node.SetLeftLinePosition( leftPosition );
                    yield return StartCoroutine( RenderTree( tree.left, leftPosition, horizontalSpace ) );
                }
                else
                {
                    node.DestroyLeftLine();
                }

                if (tree.right != null)
                {
                    Vector3 rightPosition = position + ( Vector3.right * horizontalSpace );
                    node.SetRightLinePosition( rightPosition );
                    yield return StartCoroutine( RenderTree( tree.right, rightPosition, horizontalSpace ) );
                }
                else
                {
                    node.DestroyRightLine();
                }
            }            
                
        }

        private TreeNode CreateTreeNode(Tree<int, GameObject> tree , Vector3 position)
        {          
            TreeNode node = Instantiate( nodePrefab, position, Quaternion.identity );
            InitializeNode(tree , node);

            return node;
        }

        private void RebuildBST()
        {
            //_horizontalSpace = 4.0f;
            DestroyBST();
            RenderBST();
        }

        private void InitializeNode(Tree<int , GameObject> tree , TreeNode node)
        {
            node.gameObject.name = tree.key.ToString();
            node.gameObject.transform.parent = parent;
            node.Label = tree.key.ToString();
        }

        private void DestroyBST()
        {
            Destroy(parent.gameObject);
            parent = new GameObject().transform;
        }


        public void Insert()
        {
            bst.Insert( int.Parse( inputField.text ) , null);
            inputField.text = "";
            RebuildBST();
        }

    }

}

