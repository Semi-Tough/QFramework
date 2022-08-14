#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public static class CustomShortCut
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/7.CustomShortCut %E")]
        private static void ShortCut()
        {
            EditorApplication.ExecuteMenuItem("QFramework/6.ReuseMenuItem");
        }
#endif
    }
}