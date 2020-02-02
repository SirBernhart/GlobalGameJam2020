using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPReduceThreshold : MonoBehaviour
{
    public AudioSource DamageSound;
    [SerializeField] private TowerHPManager towerHP;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "damage")
        {
            //DamageSound.Play();
            //Instantiate(DamageSound, this.transform);
            towerHP.Reduce();
        }
    }
}
