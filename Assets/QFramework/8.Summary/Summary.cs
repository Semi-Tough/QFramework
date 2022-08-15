using System;
using System.IO;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public static class Summary
    {
        public static string GenerateUnityPackageName()
        {
            return "QFramework_" + DateTime.Now.ToString("yyyyMMdd_HH");
        }

        public static void CopyToClipBoard(string str)
        {
            GUIUtility.systemCopyBuffer = str;
        }

        public static void OpenInFolder(string combine)
        {
            Application.OpenURL("file:///" + combine);
        }

#if UNITY_EDITOR
        public static void ExportUnityPackage(string assetPathName, string fileName)
        {
            AssetDatabase.ExportPackage(assetPathName, fileName, ExportPackageOptions.Recurse);
        }

        public static void ReuseMenuItem(string menuName)
        {
            EditorApplication.ExecuteMenuItem(menuName);
        }
#endif


#if UNITY_EDITOR
        [MenuItem("QFramework/8.Summary/1.GenerateUnityPackageName")]
        private static void GenerateName()
        {
            Debug.Log(GenerateUnityPackageName());
        }

        [MenuItem("QFramework/8.Summary/2.CopyToClipBoard")]
        private static void CopyName()
        {
            CopyToClipBoard("CopyToClipBoard");
        }

        [MenuItem("QFramework/8.Summary/3.GenerateUnityPackageNameToClipBoard")]
        private static void GenerateAndCopyName()
        {
            CopyToClipBoard(GenerateUnityPackageName());
        }

        [MenuItem("QFramework/8.Summary/4.ExportUnityPackage")]
        private static void ExportPackage()
        {
            ExportUnityPackage("Assets/QFramework", GenerateUnityPackageName() + ".unitypackage");
        }

        [MenuItem("QFramework/8.Summary/5.OpenInFolder")]
        private static void Open()
        {
            OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }

        [MenuItem("QFramework/8.Summary/6.ReuseMenuItem")]
        private static void Reuse()
        {
            ReuseMenuItem("QFramework/8.Summary/5.OpenInFolder");
            ReuseMenuItem("QFramework/8.Summary/4.ExportUnityPackage");
        }

        [MenuItem("QFramework/8.Summary/7.CustomShortCut")]
        private static void ShortCut()
        {
            Debug.Log("Ctrl+E");
        }
#endif
    }
}