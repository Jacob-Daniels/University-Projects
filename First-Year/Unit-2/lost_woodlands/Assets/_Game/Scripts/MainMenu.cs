using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    // load the next scene when button is pressed
    public void PlayButton()
    {
        // set the current scene to the following scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // quit the application when button is pressed
    public void QuitButton()
    {
        Application.Quit();
    }

    // play sound when a button is pressed
    public void buttonPressed()
    {
        // access a method from another class (audio manager)
        FindObjectOfType<AudioManager>().playAudio("buttonClick");
    }

    // reload the first scene
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

}
