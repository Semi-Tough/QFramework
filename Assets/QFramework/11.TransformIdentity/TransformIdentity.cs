using UnityEngine;

namespace QFramework
{
    public class TransformIdentity
    {
        public static void Identity(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localScale = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        }
    }
}