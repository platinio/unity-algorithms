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

            bool connected = qf.IsConnected( 4, 1 );

            if (connected)
            {
                Debug.Log( "4 and 1 are connected" );
            }
            else
            {
                Debug.Log("Oops 4 and 1 are not connected somethign is wrong in the Quick Find implementation!");
            }

           

        }
    }

}

