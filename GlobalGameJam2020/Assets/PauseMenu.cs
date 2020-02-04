using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseMenuUI;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
   public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Unpause()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("MenuScene");
    }

}
