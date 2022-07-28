using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    [Header("StartUp Volume")]
    public float effectsVolume = 0.25f;
    public float musicVolume = 0.25f;

    private void Update()
    {
        FindObjectOfType<AudioManager>().UpdateVolume(effectsVolume, musicVolume);
    }

    // Get values from sliders in options menu
    public void effectsSlider(float val)
    {
        effectsVolume = val;
    }

    public void musicSlider(float val)
    {
        musicVolume = val;
    }
}
