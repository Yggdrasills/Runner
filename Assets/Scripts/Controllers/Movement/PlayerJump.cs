using TRex.Controllers.Messaging;
using TRex.Utils.Extensions;
using TRex.Utils.Messaging;
using UnityEngine;


namespace TRex.Controllers.Signal
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerJump : MonoBehaviour
    {
        [SerializeField] private int _jumpheight = 5;
        [SerializeField] private float _checkRadius = default;
        [SerializeField] private Transform _groundCheck = null;
        [SerializeField] private LayerMask _groundLayer = default;

        private PlayerAnimator _playerAnimator;
        private Rigidbody2D _rigid = null;
        private bool _isGrounded = false;

        private void Awake()
        {
            _rigid = GetComponent<Rigidbody2D>();
            _playerAnimator = GetComponent<PlayerAnimator>();
        }

        private void OnEnable()
        {
            Signals.Get<JumpSignal>().AddListener(OnJumpSignal);
        }

        private void OnDisable()
        {
            Signals.Get<JumpSignal>().RemoveListener(OnJumpSignal);
        }

        private void Update()
        {
            if (_isGrounded) _playerAnimator.PlayRunAnimation();
            else _playerAnimator.PlayJumpAnimation();
        }

        private void FixedUpdate()
        {
            _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _groundLayer);
        }

        private void OnJumpSignal()
        {
            if (!CanJump()) return;

            Jump();
        }

        private bool CanJump()
        {
            return _isGrounded;
        }

        private void Jump()
        {
            _rigid.velocity = _rigid.velocity.SetVectorY(_jumpheight);

            Signals.Get<JumpSoundSignal>().Dispatch();
        }
    }
}