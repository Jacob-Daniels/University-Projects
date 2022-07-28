using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    public Slider slider;
    public PlayerCollision playerCollision;


    void Start()
    {
        // Set max slider value
        slider.maxValue = playerCollision.maxHealth;
    }


    void Update()
    {
        float health = playerCollision.health;
        slider.value = health;
    }

}
