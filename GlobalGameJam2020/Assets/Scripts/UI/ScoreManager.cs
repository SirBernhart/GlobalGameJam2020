using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int highHPMultiplier;
    private int score;

    private FMOD.Studio.EventInstance instance;

    [FMODUnity.EventRef]
    public string fmodEvent;

    [SerializeField] [Range(0, 25)]
    private float MusicVar;



    private void Start()
    {
        scoreText.text = score.ToString();
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();

    }

    public void IncreaseScore(int amount, float hpAmount)
    {
        if(hpAmount <= 80)
        {
            score += amount;
            instance.setParameterByName("EndGame", MusicVar);


        }
        else
        {
            score += amount * highHPMultiplier;
        }
        scoreText.text = score.ToString();
    }
}
