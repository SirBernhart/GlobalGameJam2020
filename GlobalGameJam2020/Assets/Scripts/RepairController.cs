using System.Collections;
using System.Collections.Generic;
using UnityEngine;

{
    [SerializeField] private CircleCollider2D repairArea;
    void Update()
    {
        if (Input.GetButtonDown("Repair"))
        {
            DoRepair();
        }
    }

    private void DoRepair()
    {
        if(repairArea.enabled == false)
        {
            Debug.Log("Repairing");
            repairArea.enabled = true;
            StartCoroutine(TimeToDisableCollider(1f));
        }
    }

    private IEnumerator TimeToDisableCollider(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        repairArea.enabled = false;
    }


}
