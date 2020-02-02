using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Credits()
    {
        Debug.Log("Credits");
        SceneManager.LoadScene("Credits");
    }
}
