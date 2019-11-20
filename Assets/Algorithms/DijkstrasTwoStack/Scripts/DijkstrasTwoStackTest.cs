using UnityEngine;
using TMPro;

namespace UnityAlgorithms
{
    public class DijkstrasTwoStackTest : MonoBehaviour
    {
        [SerializeField] private TMP_InputField inputField = null;
        [SerializeField] private TextMeshProUGUI resultLabel = null;

        public void Evaluate()
        {
            resultLabel.text = DijkstrasTwoStack.Evaluate( inputField.text ).ToString();
        }
    }
}

