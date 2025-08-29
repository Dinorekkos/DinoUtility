using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dino.Utility.Audio
{ 
    [CreateAssetMenu(fileName = "AudioManagerData", menuName = "DINO/Audio/AudioManagerData", order = 0)]
    public class AudioManagerData : ScriptableObject
    {
        public List<AudioData> audioData = new List<AudioData>();
        
        public AudioData GetAudioData(string name)
        {
            return audioData.Find(x => x.name == name);
        }
        
        
    }
    
    
    [Serializable]
    public class AudioData
    {
        public string name;
        public AudioClip clip;
        public bool loop = false;
        public float volume = 1f;
        public float pitch = 1f;
        public AudioType audioType;
    }
}