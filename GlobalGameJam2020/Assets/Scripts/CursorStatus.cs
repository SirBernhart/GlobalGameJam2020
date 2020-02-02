using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorStatus : MonoBehaviour
{
    public bool IsCursorVisible = false;

    // Start is called before the first frame update
    void Start()
    {
                Cursor.visible = IsCursorVisible;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
