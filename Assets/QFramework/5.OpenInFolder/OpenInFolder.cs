﻿using System.IO;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public static class OpenInFolder
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/5.OpenInFolder")]
#endif
        private static void Open()
        {
            string combine = Path.Combine(Application.dataPath, "../");
            Application.OpenURL("file:///" + combine);
        }
    }
}