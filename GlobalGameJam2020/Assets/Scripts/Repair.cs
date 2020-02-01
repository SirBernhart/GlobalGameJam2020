using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repair : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Repair"))
        {
            DoRepair();
        }
    }

    private void DoRepair()
    {
        Debug.Log("Repairing");
    }


}
