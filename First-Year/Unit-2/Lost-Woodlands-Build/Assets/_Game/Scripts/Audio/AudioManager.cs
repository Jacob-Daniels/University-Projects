using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    // creating array of audioClips from 'Sound' class
    public Sound[] sounds;
    private Sound playSound;

    public static AudioManager objectInstance;

    void Awake()
    {
        // preventing more than one instance of the object from occuring
        if (objectInstance == null)
        {
            objectInstance = this;
        }
        else
        {
            // remove current game object if there is more than one instance
            Destroy(gameObject);
            return;
        }

        // keep current game object to stop sound restarting
        DontDestroyOnLoad(gameObject);

        // loop through audio array and setup audio clip
        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.loop;
        }
    }

    void Start()
    {
        // play background music
        playAudio("backgroundMusic");
    }

    // method to play an audio clip by name
    public void playAudio(string name)
    {
        // find the sound clip in the array with the same name as the parameter passed in
        foreach (Sound sound in sounds)
        {
            // change pitch of audio clip 'playerJump'
            if (sound.name == "playerJump")
            {
                sound.source.pitch = Random.Range(0.7f, 1f);
            }

            // select current sound from array
            if (sound.name == name)
            {
                // pass current sound object to variable
                playSound = sound;
                break;
            }
        }

        // check if sound in in array
        if (playSound == null)
        {
            Debug.Log("Sound: '" + name + "' does not exist!");
            return;
        }

        // play the selected sound
        playSound.source.Play();
    }

    // update volume from sliders in 'OptionsMenu'
    public void updateVolume(float effectsSlider, float musicSlider)
    {
        foreach (Sound sound in sounds)
        {
            // set slider value to volume
            if (sound.name == "backgroundMusic")
            {
                sound.source.volume = musicSlider;
            }
            else
            {
                sound.source.volume = effectsSlider;
            }
        }
    }
}
