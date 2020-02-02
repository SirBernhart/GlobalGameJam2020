using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private ScoreSO so;
    public void PlayGame()
    {
        Debug.Log("Play");
        so.floor = 0;
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
