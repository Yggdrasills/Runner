using UnityEditor;

using UnityEngine;

namespace TRex.Utils.Editor
{
    public class PrefsCleaner
    {
        [MenuItem("Tools/Clear Prefs", priority = 0)]
        public static void ClearAllCache()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}