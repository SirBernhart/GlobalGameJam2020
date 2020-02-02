using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairController : MonoBehaviour
{
    [SerializeField] private float repairRadius;
    [SerializeField] private int repairScoreReward;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TowerHPManager towerHP;

    private int repairAmount = 1;
    public AudioSource Boom;

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
                Boom.Play();
                // ReduceDamage returns true if the player was able to repair it
                if (collider.gameObject.GetComponent<Damage>().ReduceDamage(repairAmount))
                {
                    towerHP.Increase();
                    scoreManager.IncreaseScore(repairScoreReward, towerHP.towerHP);
                }
            }
        }
    }
}
