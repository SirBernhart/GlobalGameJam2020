using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreSO", menuName = "ScriptableObjects/ScoreSO")]
public class ScoreSO : ScriptableObject
{
    public int score;
    public int floor;
}
