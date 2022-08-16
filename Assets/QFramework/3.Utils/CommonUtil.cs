using UnityEngine;

namespace QFramework
{
    public static class CommonUtil
    {
        public static void CopyText(string str)
        {
            GUIUtility.systemCopyBuffer = str;
        }

        public static void OpenInFolder(string combine)
        {
            Application.OpenURL("file:///" + combine);
        }
    }
}