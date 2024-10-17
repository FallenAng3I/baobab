using UnityEngine;

namespace CP3.AudioSystem
{
    public class AudioPlayerSingleton : MonoBehaviour
    {
        [SerializeField] private AudioClip clip;
        [SerializeField] private AudioSource source;
        
        public static AudioPlayerSingleton Instance
        { get; private set; }
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                return;
            }

            Destroy(gameObject);
        }

        public void PlaySound()
        {
            source.clip = clip;
            source.Play();
        }
    }
}
