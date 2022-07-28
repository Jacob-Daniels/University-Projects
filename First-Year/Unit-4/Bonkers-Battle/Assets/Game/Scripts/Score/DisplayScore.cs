using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    public GameObject scoreManager;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        scoreText.text = scoreManager.GetComponent<Score>().score.ToString();
    }

}
