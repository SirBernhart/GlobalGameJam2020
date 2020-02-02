using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultScene: MonoBehaviour
{
    public TextMeshProUGUI field;
    public int currentDisplayScore = 0;
    public int currentDisplayFloor = 0;
    public ScoreSO result;
    


    void Start()
    {

        StartCoroutine(CountUpToTarget());
    }
 
    IEnumerator CountUpToTarget()
    {
        while ((currentDisplayScore < result.score) && (currentDisplayFloor < result.floor))
        {
            currentDisplayFloor += 1; 
            currentDisplayFloor = (int)Mathf.Clamp(currentDisplayScore, 0f, result.score);
            currentDisplayScore += 3; // or whatever to get the speed you like
            currentDisplayScore = (int)Mathf.Clamp(currentDisplayScore, 0f, result.score);
            field.text =  result.floor + " floors repaired! \n" + currentDisplayScore + " points collected! \n\nBetter luck next time";
            yield return null;
    
        }
    }
 
}
 
 