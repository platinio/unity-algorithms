using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DictonaryTest : MonoBehaviour
{
    public int[] array = null;

    private Dictionary<int, bool> hashTable = new Dictionary<int, bool>();

    private void Awake()
    {
        hashTable[5] = true;

        if (hashTable.ContainsKey( 5 ))
        {
            Debug.Log("Contains key 5");
        }

        int[] result = Solution_2( array , 10 );

        Debug.Log( result[0] + " " + result[1] );
    }

    public static int[] Solution_2(int[] array, int targetSum)
    {
        Dictionary<int, bool> hashTable = new Dictionary<int, bool>();

        for (int n = 0; n < array.Length; n++)
        {

            int desireValue = targetSum - array[n];

            if (hashTable.ContainsKey( desireValue ))
            {
                return new int[] { array[n], desireValue };
            }

            else
            {
                hashTable[array[n]] = true;
            }

        }

        return new int[0];

    }

}
