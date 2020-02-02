using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScroll : MonoBehaviour
{
    void Update()
    {
        float moveSpeed = DifficultyManager.velocidade * Time.deltaTime;
        transform.position = transform.position + new Vector3(0, -moveSpeed, 0);
    }
}
