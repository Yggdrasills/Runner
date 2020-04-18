using TRex.Utils.Extensions;
using UnityEngine;

namespace TRex
{
    public class ResolutionResolver : MonoBehaviour
    {
        [SerializeField] private float _fartherPosition = -7.8f;
        [SerializeField] private Transform _playerTransform = null;

        private void Awake()
        {
            float fartherAspect = (float)21 / 9;

            _playerTransform.SetPositionX(_fartherPosition * Camera.main.aspect / fartherAspect);
        }
    }
}