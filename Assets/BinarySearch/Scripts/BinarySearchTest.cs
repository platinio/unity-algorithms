using UnityEngine;

namespace UnityAlgorithms
{
    public class BinarySearchTest : MonoBehaviour
    {
        [SerializeField] private int[] array = null;
        [SerializeField] private int key = 0;

        private void Awake()
        {
            BinarySearch bs = new BinarySearch();
            int result =  bs.DoABinarySearch(array , key);

            Debug.Log("result of bs " + result);

        }
    }
}

