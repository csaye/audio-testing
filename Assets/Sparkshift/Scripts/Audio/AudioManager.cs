using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sparkshift.Audio
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager instance;
        
        [Header("Attributes")]
        public List<AudioReference> sounds;

        [Header("References")]
        public AudioSource audioSource;

        private Dictionary<int, AudioClip> audioDictionary = new Dictionary<int, AudioClip>();

        private void Start()
        {
            if (instance == null)
            {
                instance = this;
            }

            for (int i = 0; i < sounds.Count; i++)
            {
                audioDictionary.Add(sounds[i].audioID, sounds[i].audioClip);
            }
        }

        public void PlaySound(int audioID)
        {
            try
            {
                audioSource.clip = audioDictionary[audioID];
                audioSource.Play();
            }
            catch
            {
                Debug.LogError("Sound " + audioID + " not found.");
            }
        }
    }
}
