using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public class CopyToClipBoard : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/2.CopyToClipBoard")]
#endif
        private static void Copy()
        {
            GUIUtility.systemCopyBuffer = "CopyToClipBoard";
        }
    }
}