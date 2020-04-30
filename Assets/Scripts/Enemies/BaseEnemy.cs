using BunnyHop.Controllers.Messaging;
using BunnyHop.Utils.Messaging;
using UnityEngine;

namespace BunnyHop.Enemies
{
    [RequireComponent(typeof(Collider2D))]
    public class BaseEnemy : MonoBehaviour, IEnemy
    {
        [SerializeField] private float _distanceToDestroy = -10.5f;

        private void Update()
        {
            if (transform.position.x < _distanceToDestroy) Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.CompareTag(PlayerConstants.PlayerTag)) return;

            HitPlayer();
        }

        public void HitPlayer()
        {
            Signals.Get<GameOverSignal>().Dispatch();
        }
    }
}