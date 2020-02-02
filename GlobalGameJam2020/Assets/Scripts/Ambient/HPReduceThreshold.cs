using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPReduceThreshold : MonoBehaviour
{
        public GameObject DamageSound;

    [SerializeField] private TowerHPManager towerHP;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "damage")
        {
            Instantiate(DamageSound, this.transform);
            towerHP.Reduce();
        }
    }
}
