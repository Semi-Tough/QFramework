using System;
using System.IO;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public static class Exporter
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/ExportUnityPackage %E", false, 1)]
        private static void ExportPackage()
        {
            EditorUtil.ExportPackage("Assets/QFramework", GeneratePackageName() + ".unitypackage");
            CommonUtil.OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }

#endif

        private static string GeneratePackageName()
        {
            return "QFramework_" + DateTime.Now.ToString("yyyyMMdd_HH");
        }
    }
}