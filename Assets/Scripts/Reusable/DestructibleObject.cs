using UnityEngine;

namespace BunnyHop.Reusable
{
    public abstract class DestructibleObject : MonoBehaviour
    {
        [SerializeField]
        private float _distanceToDestroy = 10.5f;
        private float _destroyDistance;

        private void Awake()
        {
            _destroyDistance = transform.position.x - _distanceToDestroy;
        }

        private void Update()
        {
            if (transform.position.x < _destroyDistance) Destroy(gameObject);
        }
    }
}