using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public class ExportUnityPackage : MonoBehaviour
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