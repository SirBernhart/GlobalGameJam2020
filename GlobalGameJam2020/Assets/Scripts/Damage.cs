using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private int damageLevel;

    public void ReduceDamage(int howMuch)
    {
        if(--damageLevel <= 0)
        {
            FinishRepairs();
        }
    }

    private void FinishRepairs()
    {
        Destroy(gameObject);
    }
}
