using UnityEngine;

namespace TRex.Controllers.Sounds
{
    public class ScoringSound : Sound
    {
        [SerializeField] private AudioClip _scoreSound = null;

        public void PlayScoreSound()
        {
            PlayOneShot(_scoreSound);
        }

        public void PlaySound()
        {
            PlaySound(_scoreSound);
        }
    }
}