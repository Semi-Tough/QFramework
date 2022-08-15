using UnityEngine;

namespace QFramework
{
    public class SimplyGameObjectSetActive
    {
        public static void Show(GameObject gameObject)
        {
            gameObject.SetActive(true);
        }

        public static void Hide(GameObject gameObject)
        {
            gameObject.SetActive(false);
        }
    }
}