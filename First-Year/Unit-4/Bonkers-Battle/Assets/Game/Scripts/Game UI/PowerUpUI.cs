using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUpUI : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    public TextMeshProUGUI TMProText;

    [Header("Variables")]
    public float maxTimer = 3f;
    public float timer;
    [Header("Rotation")]
    public float rotateSpeed = 1f;
    public float angleY = 30f;

    void Start()
    {
        TMProText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        // Display on screen when timer is above 0f
        if (timer > 0f)
        {
            timer -= 1 * Time.deltaTime;
        } else
        {
            TMProText.text = "";
        }

        // Rotate object
        float rotateY = Mathf.SmoothStep(-angleY, angleY, Mathf.PingPong(Time.time * rotateSpeed, 1));
        transform.rotation = Quaternion.Euler(0, rotateY, 0);
    }

    public void DisplayText(Vector3 textPos, string text)   // Position and Set UI Text when called to
    {
        textPos.y += 3f;
        // set pos and text
        transform.position = textPos;
        TMProText.text = text;
        // set timer
        timer = maxTimer;
    }

}
