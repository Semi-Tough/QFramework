using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public class GenerateUnityPackageName
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/1.GenerateUnityPackageName")]
#endif
        private static void Generate()
        {
            Debug.Log("QFramework_" + DateTime.Now.ToString("yyyy/MM/dd_HH"));
        }
    }
}