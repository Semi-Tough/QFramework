using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public static class ExportUnityPackage
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/4.ExportUnityPackage")]
        private static void Export()
        {
            string assetPathName = "Assets/QFramework";
            string fileName = "QFramework_" + DateTime.Now.ToString("yyyyMMdd_HH") + ".unitypackage";
            AssetDatabase.ExportPackage(assetPathName, fileName, ExportPackageOptions.Recurse);
        }
#endif
    }
}