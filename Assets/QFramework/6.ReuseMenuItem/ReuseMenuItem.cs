#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public static class ReuseMenuItem
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/6.ReuseMenuItem")]
        private static void Reuse()
        {
            EditorApplication.ExecuteMenuItem("QFramework/4.ExportUnityPackage");
            EditorApplication.ExecuteMenuItem("QFramework/5.OpenInFolder");
        }
#endif
    }
}