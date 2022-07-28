using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadBar : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    public Slider slider;
    public ShootProjectile SP;
    public GameObject fullbar;

    [Header("Slider Colour")]
    public Color fullColor;
    public Color cooldownColor;

    void Start()
    {
        // Set Colours
        fullColor = new Color(42f/255f, 106f/255f, 0f);
        cooldownColor = new Color(125f/255f, 0f, 0f);
        // Set Slider Max Value
        //slider.maxValue = SP.maxTimer;
    }


    void Update()
    {
        slider.maxValue = SP.maxTimer;
        slider.value = SP.timer;

        if (slider.value == slider.maxValue)
        {
            fullbar.GetComponent<Image>().color = fullColor;
        } else
        {
            fullbar.GetComponent<Image>().color = cooldownColor;
        }

    }
}
