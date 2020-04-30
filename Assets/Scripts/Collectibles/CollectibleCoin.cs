using UnityEngine;

namespace BunnyHop.Collectibles
{
    public class CollectibleCoin : CollectibleBase, ICollectible
    {
        [SerializeField]
        private ParticleSystem _particles = null;

        public void Collect()
        {
            gameObject.SetActive(false);

            if (_particles == null) return;

            var particles = Instantiate(_particles);
            particles.transform.position = transform.position;
            particles.Play();
        }

        protected override void OnPlayerDetected()
        {
            Collect();
        }
    }
}