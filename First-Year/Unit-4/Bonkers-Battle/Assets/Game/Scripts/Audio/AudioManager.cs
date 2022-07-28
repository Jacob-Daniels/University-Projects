using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Clips")]
    public Sound[] sounds;
    public static AudioManager instance;

    private void Awake()
    {
        // Check if instance already exists in scene
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        // Add a new AudioSource component for each sound clip in the array
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        // Play the background music in scene
        Play("MenuMusic");
    }

    public void Play(string name)   // Play audio clip
    {
        // Find the sounds in the array equal to the [name] parameter
        Sound s = Array.Find(sounds, s => s.name == name);
        // Check if clip is in array
        if (s == null)
        {
            Debug.LogWarning("Can't Play() audio clip called:" + name);
            return;
        }
        CheckClip(s);
        s.source.Play();
    }
    public void CheckClip(Sound s)
    {
        if (s.name == "HankDeath") // Change Pitch of sound when enemy dies
        {
            s.source.pitch = UnityEngine.Random.Range(0.8f, 1.2f);
            return;
        } else if (s.name == "RemyDeath")
        {
            s.source.pitch = UnityEngine.Random.Range(1.5f, 1.8f);
        }
    }

    public void Stop(string name)   // Stop audio clip playing
    {
        Sound s = Array.Find(sounds, s => s.name == name);
        if (s == null)
        {
            Debug.LogWarning("Can't Stop() audio clip called:" + name);
            return;
        }
        s.source.Stop();
    }

    // Update volume from sliders
    public void UpdateVolume(float effectsVolume, float musicVolume)
    {
        foreach (Sound s in sounds)
        {
            // set slider value to volume
            if (s.name == "MenuMusic" || s.name == "GameMusic" || s.name == "DeathMusic")
            {
                s.source.volume = musicVolume;
            }
            else
            {
                s.source.volume = effectsVolume;
            }
        }
    }
}
