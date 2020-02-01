﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSpawner : MonoBehaviour
{

    public GameObject[] damageList;
    [HideInInspector]
    public int difficulty;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<difficulty;i++)
        {
            int index = Random.Range(0,damageList.Length - 1);
            if(!damageList[index].active)
                damageList[index].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}