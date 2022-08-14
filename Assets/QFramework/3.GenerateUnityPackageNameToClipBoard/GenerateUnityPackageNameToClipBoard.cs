﻿using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public class GenerateUnityPackageNameToClipBoard : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/3.GenerateUnityPackageNameToClipBoard")]
#endif

        private static void Generate()
        {
            GUIUtility.systemCopyBuffer = "QFramework_" + DateTime.Now.ToString("yyyyMMdd_HH");
        }
    }
}