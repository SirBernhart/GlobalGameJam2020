using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScroll : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        moveSpeed *= Time.deltaTime;
    }

    void Update()
    {
        transform.position = transform.position + new Vector3(0, -moveSpeed, 0);
    }
}
