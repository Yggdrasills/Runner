using UnityEngine;
using TRex.Utils.Messaging;
using TRex.Controllers.Messaging;

namespace TRex.Controllers.Sounds
{
    public class PlayerSound : Sound
    {
        [SerializeField] private AudioClip _jumpSound = null;
        [SerializeField] private AudioClip _dieSound = null;

        private void OnEnable()
        {
            Signals.Get<JumpSoundSignal>().AddListener(PlayJumpSound);
            Signals.Get<GameOverSignal>().AddListener(PlayDieSound);
        }

        private void OnDisable()
        {
            Signals.Get<JumpSoundSignal>().RemoveListener(PlayJumpSound);
            Signals.Get<GameOverSignal>().RemoveListener(PlayDieSound);
        }

        private void PlayJumpSound()
        {
            PlayOneShot(_jumpSound);
        }

        private void PlayDieSound()
        {
            PlayOneShot(_dieSound);
        }
    }
}