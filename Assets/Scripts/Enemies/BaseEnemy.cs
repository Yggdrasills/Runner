using BunnyHop.Controllers.Messaging;
using BunnyHop.Reusable;
using BunnyHop.Utils.Messaging;
using UnityEngine;

namespace BunnyHop.Enemies
{
    [RequireComponent(typeof(Collider2D))]
    public class BaseEnemy : DestructibleObject, IEnemy
    {
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