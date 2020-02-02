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

    private Coroutine decreaseHPCoroutine;
    private void Start()
    {
        //decreaseHPCoroutine = StartCoroutine(DecreaseHPOverTime());
    }

    [SerializeField] private Image healthBar;

    public void Increase()
    {
        towerHP += HPToIncrease;
        if (towerHP >= 100)
            towerHP = 100;
        UpdateHealthBar();
    }

    public void Reduce(float damage = 0)
    {
        if(damage != 0)
        {
            towerHP -= damage;
        }
        else
        {
            towerHP -= HPToReduce;
        }
        UpdateHealthBar();
        if(towerHP <= 0)
        {
            EndGame();
        }
    }

    private IEnumerator DecreaseHPOverTime()
    {
        WaitForSeconds timeBetweenDamage = new WaitForSeconds(1f);
        while (true)
        {
            yield return timeBetweenDamage;
            Reduce(HPToReduceOverTime);
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
