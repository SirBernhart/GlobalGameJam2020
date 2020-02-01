using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private int damageLevel;

    public bool ReduceDamage(int howMuch)
    {
        if(--damageLevel <= 0)
        {
            StartCoroutine(FinishRepairs());
            return true;
        }
        return false;
    }

    private IEnumerator FinishRepairs()
    {
        yield return new WaitForEndOfFrame();
        Destroy(gameObject);
    }
}
