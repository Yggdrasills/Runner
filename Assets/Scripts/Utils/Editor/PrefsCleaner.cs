using UnityEditor;

using UnityEngine;

namespace BunnyHop.Utils.Editor
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