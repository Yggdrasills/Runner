using UnityEngine;
using UnityEngine.SceneManagement;

namespace TRex.GameProcess
{
    public class SceneLoader : MonoBehaviour
    {
        /// <summary>
        /// Callback From Scene
        /// </summary>
        /// <param name="index"></param>
        public void LoadGameScene(int index)
        {
            SceneManager.LoadScene(index);
        }
    }
}