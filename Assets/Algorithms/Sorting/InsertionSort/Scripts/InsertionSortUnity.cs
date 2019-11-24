using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace UnityAlgorithms
{
    public class InsertionSortUnity : MonoBehaviour
    {
        [SerializeField] private int numberOfCubes = 50;
        [SerializeField] private float cubeMaxSize = 15.0f;
        [SerializeField] private float spacing = 0.5f;
        [SerializeField] private Color fromColor = Color.black;
        [SerializeField] private Color toColor = Color.black;
        [SerializeField] private float delay = 0.5f;

        private void Awake()
        {
            SpawnRandomCubes();
            StartCoroutine( InsertionSortRoutine() );
        }

        private void SpawnRandomCubes()
        {
            for (int n = 0; n < numberOfCubes; n++)
            {
                CreateCube(n);
            }
        }

        private void CreateCube(int index)
        {
            GameObject go = GameObject.CreatePrimitive( PrimitiveType.Cube );
            float cubeSize = Random.Range( 0.1f, cubeMaxSize);
            go.transform.localScale = new Vector3(0.25f , cubeSize , 0.25f );
            go.transform.position = transform.position + ( Vector3.up * ( cubeSize / 2.0f ) );
            go.transform.position = go.transform.position + ( Vector3.right * spacing * index );
            go.transform.parent = transform;

            MeshRenderer render = go.GetComponent<MeshRenderer>();
            render.material = new Material( Shader.Find("Particles/Standard Unlit") );
            render.material.color = Color.Lerp( fromColor , toColor , cubeSize / cubeMaxSize );

        }

        private IEnumerator InsertionSortRoutine()
        {
            for (int n = 0; n < transform.childCount; n++)
            {
                for (int j = n; j > 0; j--)
                {
                    if (transform.GetChild(j).localScale.y < transform.GetChild( j - 1 ).localScale.y)
                    {
                        Swap( j , j - 1 );
                        yield return new WaitForSeconds(delay);
                    }
                    else
                    {
                        break;
                    }


                }
            }
        }

        private void Swap(int childA , int childB)
        {
            Transform transformA = transform.GetChild( childA );
            Transform transformB = transform.GetChild( childB );

            Vector3 childAPosition = transformA.position;
            transformA.position = new Vector3( transformB.position.x , transformA.position.y , transformB.position.z );
            transformB.position = new Vector3( childAPosition.x , transformB.position.y , childAPosition.z );

            int silbingIndexA = transformA.GetSiblingIndex();
            transformA.SetSiblingIndex( transformB.GetSiblingIndex() );
            transformB.SetSiblingIndex( silbingIndexA );
        }

        


    }
}

