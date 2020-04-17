using TRex.Constants;
using TRex.Controllers.Messaging;
using TRex.Utils.Messaging;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TRex.Controllers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameObject _UICanvas = null;

        private void Awake()
        {
            Time.timeScale = 1;
        }

        private void OnEnable()
        {
            Signals.Get<GameOverSignal>().AddListener(ShowCanvas);
            Signals.Get<GameOverSignal>().AddListener(FreezeTime);
        }

        private void OnDisable()
        {
            Signals.Get<GameOverSignal>().RemoveListener(ShowCanvas);
            Signals.Get<GameOverSignal>().RemoveListener(FreezeTime);
        }

        private void ShowCanvas()
        {
            if(_UICanvas == null)
            {
                Debug.LogError("There is no canvas");
                return;
            }

            _UICanvas.SetActive(true);
        }

        private void FreezeTime()
        {
            Time.timeScale = 0;
        }

        public void RestartScene()
        {
            SceneManager.LoadScene(GameConstants.GameScene);
        }
    }
}