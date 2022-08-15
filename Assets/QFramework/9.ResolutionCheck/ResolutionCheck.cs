using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFramework
{
    public static class ResolutionCheck
    {
#if UNITY_EDITOR

        [MenuItem("QFramework/9.GetAspectRatio")]
#endif
        private static void AspectRatio()
        {
            Debug.Log(IsPadResolution() ? "是 pad 分辨率" : "不是 pad 分辨率");
            Debug.Log(IsPhoneResolution() ? "是 phone 分辨率" : "不是 phone 分辨率");
        }

        public static float GetAspect()
        {
            return Screen.width > Screen.height
                ? (float) Screen.width / Screen.height
                : (float) Screen.height / Screen.width;
        }

        public static bool IsPadResolution()
        {
            return AtAspectRange(4.0f / 3);
        }

        public static bool IsPhoneResolution()
        {
            return AtAspectRange(16.0f / 9);
        }


        public static bool AtAspectRange(float aspectRadio)
        {
            float aspect = GetAspect();
            return aspect > aspectRadio - 0.05 && aspect < aspectRadio + 0.05;
        }
    }
}