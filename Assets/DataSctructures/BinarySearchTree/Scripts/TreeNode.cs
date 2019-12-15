using UnityEngine;

namespace UnityAlgorithms
{
    public class TreeNode : MonoBehaviour
    {
        [SerializeField] private LineRenderer leftLine = null;
        [SerializeField] private LineRenderer rightLine = null;
        [SerializeField] private TextMesh textMesh = null;

        public string Label { set { textMesh.text = value; } }


        public void SetLeftLinePosition(Vector3 position)
        {
            RenderLineTo(leftLine , position);
        }

        public void SetRightLinePosition(Vector3 position)
        {
            RenderLineTo(rightLine , position);
        }

        private void RenderLineTo(LineRenderer lineRender , Vector3 position)
        {
            if (lineRender != null)
            {
                lineRender.positionCount = 2;
                lineRender.SetPosition( 0, transform.position );
                lineRender.SetPosition( 1, position );
            }

            
        }

        public void DestroyLeftLine()
        {
            Destroy( leftLine );
        }

        public void DestroyRightLine()
        {
            Destroy(rightLine);
        }

    }
}

