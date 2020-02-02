using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScroll : MonoBehaviour
{
    private float delta;
    private void Start()
    {
        delta = Time.deltaTime;
    }

    void Update()
    {
        float moveSpeed = DifficultyManager.velocidade * delta;
        transform.position = transform.position + new Vector3(0, -moveSpeed, 0);
    }
}
