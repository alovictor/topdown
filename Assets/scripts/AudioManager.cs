using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    void Awake(){
        foreach (Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            
        }
    }
    public void Play(string nome){
        Sound s = Array.Find(sounds, sound => sound.name == nome);
        Debug.Log(s);
        s.source.Play();
    }

}
