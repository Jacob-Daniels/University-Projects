using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// class to store audio clips to be called during gameplay
[System.Serializable]
public class Sound
{
    // variables for each audio clip (altered in the inspector)
    public string name;

    public AudioClip clip;

    // create a slider in the inspector for the variable
    [Range(0,1)] public float volume;
    [Range(-2,2)] public float pitch = 1;

    public bool loop;

    // store each audio clip & variables
    [HideInInspector] public AudioSource source;
}
