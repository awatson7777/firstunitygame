using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour { // this script is used for the main menu. 

	public void PlayTheGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // this loads the scene in position 1 within the build manager.
    }

    public void QuitTheGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
