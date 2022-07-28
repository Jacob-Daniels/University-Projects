using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [Header("Score")]
    public int score;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


    public void addScore()  // Increase score
    {
        score++;
    }

}
