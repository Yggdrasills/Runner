using UnityEngine;

namespace BunnyHop.Controllers.Sounds
{
    public class ClipShotSound : Sound
    {
        [SerializeField]
        private AudioClip[] _clips;

        /// <summary>
        /// Callback from animator
        /// </summary>
        public void PlayShotByIndex(int index)
        {
            if (index >= _clips.Length) return;

            PlayOneShot(_clips[index]);
        }
    }
}