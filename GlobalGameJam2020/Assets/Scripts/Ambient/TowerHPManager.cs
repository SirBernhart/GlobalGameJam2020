using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TowerHPManager : MonoBehaviour
{
    public float towerHP;
    public float maxTowerHP;
    public float HPToReduce;
    public float HPToReduceOverTime;
    public float HPToIncrease;

    [SerializeField] private Image healthBar;

    public void Increase()
    {
        towerHP += HPToIncrease;
        if (towerHP >= 100)
            towerHP = 100;
        UpdateHealthBar();
    }

    public void Reduce()
    {
        towerHP -= HPToReduce;
        UpdateHealthBar();
        if(towerHP <= 0)
        {
            EndGame();
        }
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = towerHP / maxTowerHP;
    }

    private void EndGame()
    {
        SceneManager.LoadScene("ResultsScene");
    }
}
