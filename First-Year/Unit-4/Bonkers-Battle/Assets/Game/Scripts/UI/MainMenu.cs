using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [HideInInspector]
    public GameObject checkScore;
    [HideInInspector]
    public AudioManager audioM;

    private void Start()
    {
        audioM = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    public void startGame()
    {
        // load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void replayGame()
    {
        // Reset Variables/Audio
        if (GameObject.Find("ScoreManager") == true)
        {
            Destroy(GameObject.Find("ScoreManager"));
        }
        audioM.Stop("DeathMusic");
        audioM.Play("GameMusic");

        // reload game
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        // close the application
        Application.Quit();
    }
}
