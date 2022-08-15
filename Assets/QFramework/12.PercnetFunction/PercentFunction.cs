using UnityEngine;

namespace QFramework
{
    public class PercentFunction
    {
        public static bool Percent(int percent)
        {
            return Random.Range(0, 100) < percent;
        }
    }
}