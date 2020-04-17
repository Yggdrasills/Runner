using TRex.Utils.Extensions;

using UnityEngine;

namespace TRex.Controllers
{
    public class BackgroundShifter : MonoBehaviour
    {
        [SerializeField] private Transform[] _backgrounds = null;
        [SerializeField] private float _offset = 42;
        private float _halfOffset;
        private Transform _cameraTransform;
        private int _currentIndex;

        private void Awake()
        {
            _cameraTransform = Camera.main.transform;
            _halfOffset = _offset * 0.5f;
        }

        private void Update()
        {
            if (!CanSwitch()) return;

            SwitchPosition();
        }

        private void SwitchPosition()
        {
            _backgrounds[_currentIndex++].AddPositionX(_offset);
            
            if(_currentIndex >= _backgrounds.Length) _currentIndex = 0;
        }

        private bool CanSwitch()
        {
            return (_cameraTransform.position.x % _halfOffset).isNearlyEqual(0, 5) &&
                _backgrounds[_currentIndex].position.x + _halfOffset <= _cameraTransform.position.x;
        }
    }
}