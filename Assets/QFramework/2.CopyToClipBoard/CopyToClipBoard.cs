using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public static class CopyToClipBoard 
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