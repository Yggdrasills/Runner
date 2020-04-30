using BunnyHop.Reusable;
using UnityEngine;

namespace BunnyHop.Collectibles
{
    public abstract class CollectibleBase : DestructibleObject
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.CompareTag(PlayerConstants.PlayerTag)) return;

            OnPlayerDetected();
        }

        protected abstract void OnPlayerDetected();
    }
}