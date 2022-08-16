using System;
using System.Collections;
using UnityEngine;

namespace QFramework
{
    public abstract class MonoBehaviorSimply : MonoBehaviour
    {
        #region SetLocalPosition

        public static void SetLocalPosX(Transform transform, float x)
        {
            Vector3 localPos = transform.localPosition;
            localPos.x = x;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosY(Transform transform, float y)
        {
            Vector3 localPos = transform.localPosition;
            localPos.y = y;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosZ(Transform transform, float z)
        {
            Vector3 localPos = transform.localPosition;
            localPos.z = z;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosXY(Transform transform, float x, float y)
        {
            Vector3 localPos = transform.localPosition;
            localPos.x = x;
            localPos.y = y;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosXZ(Transform transform, float x, float z)
        {
            Vector3 localPos = transform.localPosition;
            localPos.x = x;
            localPos.z = z;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosYZ(Transform transform, float y, float z)
        {
            Vector3 localPos = transform.localPosition;
            localPos.y = y;
            localPos.z = z;
            transform.localPosition = localPos;
        }

        #endregion

        #region TransformIdentity

        public static void TransformIdentity(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localScale = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        }

        #endregion

        #region DelayWithCoroutine

        public void Delay(float seconds, Action callBack)
        {
            StartCoroutine(DelayCoroutine(seconds, callBack));
        }

        private static IEnumerator DelayCoroutine(float seconds, Action callBack)
        {
            yield return new WaitForSeconds(seconds);
            callBack.Invoke();
        }

        #endregion
    }
}