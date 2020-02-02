using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultScene: MonoBehaviour
{
    public TextMeshProUGUI field;
    public int targetScore;
    public int currentDisplayScore = 0;
 
 
    void Start()
    {
        StartCoroutine(CountUpToTarget());
    }
 
    IEnumerator CountUpToTarget()
    {
        while (currentDisplayScore < targetScore)
        {
            currentDisplayScore += 3; // or whatever to get the speed you like
            currentDisplayScore = (int)Mathf.Clamp(currentDisplayScore, 0f, targetScore);
            field.text =  DifficultyManager.nChunks + " floors repaired! \n" + currentDisplayScore + " points collected! \n\nBetter luck next time";
            yield return null;
        }
    }
 
}
 
 