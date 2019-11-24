using System.Collections.Generic;

namespace UnityAlgorithms
{
    public static class MergeSortAlgorithm
    {



        public static List<int> MergeSort(List<int> unsortedList)
        {
            if (unsortedList.Count <= 1)
                return unsortedList;

            int halfSize = unsortedList.Count / 2;
            
            List<int> left = new List<int>( halfSize );
            List<int> right = new List<int>( halfSize );

            for (int n = 0; n < halfSize; n++)
            {
                left.Add(unsortedList[n]);
               
            }

            for (int n = halfSize; n < unsortedList.Count; n++)
            {
                right.Add( unsortedList[n] );
            }

           

            left = MergeSort( left );
            right = MergeSort( right );

            return Merge( left , right );
        }

        public static List<int> Merge(List<int> left , List<int> right)
        {
            int resultSize = left.Count + right.Count;
            List<int> result = new List<int>(resultSize);


            for (int n = 0; n < resultSize; n++)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] < right[0])
                    {
                        result.Add( left[0] );
                        left.RemoveAt( 0 );

                    }

                    else
                    {
                        result.Add( right[0] );
                        right.RemoveAt( 0 );
                    }
                }
                else
                {
                    if (right.Count > 0)
                    {
                        result.Add( right[0] );
                        right.RemoveAt( 0 );
                    }
                    else if (left.Count > 0)
                    {
                        result.Add( left[0] );
                        left.RemoveAt( 0 );
                    }
                }
                
            }

            return result;

        }
    }
}


