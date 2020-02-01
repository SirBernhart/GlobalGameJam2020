using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int highHPMultiplier;
    private int score;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

    public void IncreaseScore(int amount, float hpAmount)
    {
        if(hpAmount <= 80)
        {
            score += amount;
        }
        else
        {
            score += amount * highHPMultiplier;
        }
        scoreText.text = score.ToString();
    }
}
