using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    private float effectsValue = 0.25f;
    private float musicValue = 0.25f;

    void Update()
    {
        // update volume
        FindObjectOfType<AudioManager>().updateVolume(effectsValue, musicValue);
    }

    // get value from effects slider when changed
    public void effectsSlider(float val)
    {
        effectsValue = val;
    }

    // get value from music slider when changed
    public void musicSlider(float val)
    {
        musicValue = val;
    }
}
