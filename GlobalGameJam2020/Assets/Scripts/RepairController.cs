using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairController : MonoBehaviour
{
    [SerializeField] private float repairRadius;
    void Update()
    {
        if (Input.GetButtonDown("Repair"))
        {
            DoRepair();
        }
    }

    private void DoRepair()
    {
        List<Collider2D> collidedWith = new List<Collider2D>();
        Physics2D.OverlapCircle(transform.position, repairRadius, new ContactFilter2D(), collidedWith);

        foreach(Collider2D collider in collidedWith)
        {
            if(collider.tag == "damage")
            {
                collider.gameObject.GetComponent<Damage>().ReduceDamage(1);
            }
        }
    }
}
