using BunnyHop.Constants;
using UnityEngine;

namespace BunnyHop.Controllers
{
    [RequireComponent(typeof(Animator))]
    public class PlayerAnimator : MonoBehaviour
    {
        private Animator _animator;
        private int _runAnimationTrigger = Animator.StringToHash(PlayerConstants.RunAnimationTrigger);
        private int _jumpAnimationTrigger = Animator.StringToHash(PlayerConstants.JumpAnimationTrigger);

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void PlayJumpAnimation()
        {
            SetAnimatorTrigger(_jumpAnimationTrigger);
        }

        public void PlayRunAnimation()
        {
            SetAnimatorTrigger(_runAnimationTrigger);
        }

        private void SetAnimatorTrigger(int triggerIndex)
        {
            _animator.SetTrigger(triggerIndex);
        }
    }
}