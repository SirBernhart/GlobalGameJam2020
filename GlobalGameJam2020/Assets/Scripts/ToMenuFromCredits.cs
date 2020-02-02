using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenuFromCredits : MonoBehaviour
{      public void voltar()
    {
        Debug.Log("Menu");
        SceneManager.LoadScene("MenuScene");
    }
}
