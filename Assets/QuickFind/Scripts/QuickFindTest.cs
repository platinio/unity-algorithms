using UnityEngine;

namespace UnityAlgorithms
{
    public class QuickFindTest : MonoBehaviour
    {
        [SerializeField] private QuickFind qf;

        private void Awake()
        {
            qf = new QuickFind(10);
            qf.CreateConnection(0 , 5);
            qf.CreateConnection(0 , 6);
            qf.CreateConnection(1 , 2);
            qf.CreateConnection(2 , 7);
            qf.CreateConnection(2 , 8);
            qf.CreateConnection(8 , 3);
            qf.CreateConnection(3 , 9);
            qf.CreateConnection(9 , 4);

            Debug.Log(qf.IsConnected(4 , 1));

        }
    }

}

