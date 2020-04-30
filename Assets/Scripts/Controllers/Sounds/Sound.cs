using UnityEngine;

namespace BunnyHop.Controllers.Sounds
{
    [RequireComponent(typeof(AudioSource))]
    public abstract class Sound : MonoBehaviour
    {
        private AudioSource _source;

        private void Awake()
        {
            _source = GetComponent<AudioSource>();
            SetupSource();
        }

        private void SetupSource()
        {
            _source.playOnAwake = false;
            _source.loop = false;
            _source.volume = 1;
        }

        protected void PlayOneShot(AudioClip clip)
        {
            if (clip == null) return;

            _source.PlayOneShot(clip);
        }

        protected void PlaySound(AudioClip clip)
        {
            if (_source.isPlaying) return;

            _source.PlayOneShot(clip);
        }
    }
}