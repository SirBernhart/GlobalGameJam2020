using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPReduceThreshold : MonoBehaviour
{
    public AudioSource DamageSound;
    public Animator CameraShake;
    [SerializeField] private TowerHPManager towerHP;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "damage")
        {
            DamageSound.Play();
            //Instantiate(DamageSound, this.transform);
            towerHP.Reduce();
            CameraShake.SetTrigger("Shake");
        }
    }
}
