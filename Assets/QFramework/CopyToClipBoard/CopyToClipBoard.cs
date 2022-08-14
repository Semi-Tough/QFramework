using UnityEditor;
using UnityEngine;

namespace QFramework
{
    public class CopyToClipBoard : MonoBehaviour
    {
        [MenuItem("QFramework/2.CopyToClipBoard")]
        private static void Copy()
        {
            GUIUtility.systemCopyBuffer = "CopyToClipBoard";
        }
    }
}