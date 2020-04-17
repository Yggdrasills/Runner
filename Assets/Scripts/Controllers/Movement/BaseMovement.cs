using UnityEngine;

namespace TRex.Controllers.Movement
{
    public class BaseMovement : MonoBehaviour, IMovable
    {
        [SerializeField] private float _speed = 5;

        private void Update()
        {
            Move(_speed);
        }

        public void Move(float speed)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            OnMove();
        }

        protected virtual void OnMove() { }
    }
}