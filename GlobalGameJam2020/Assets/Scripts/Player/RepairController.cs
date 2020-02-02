using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairController : MonoBehaviour
{
    [SerializeField] private float repairRadius;
    [SerializeField] private int repairScoreReward;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TowerHPManager towerHP;
    [SerializeField] private Transform canonTip;
    public ScoreSO Score;
    public ScreenShake screenShake;

    private int repairAmount = 1;
    public AudioSource Boom;

    void Start()
    {
        Score.score = 0;
    }

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
        Physics2D.OverlapCircle(canonTip.position, repairRadius, new ContactFilter2D(), collidedWith);

        foreach(Collider2D collider in collidedWith)
        {
            if(collider.tag == "damage")
            {
                Boom.Play();
                this.GetComponent<RandomizerVocal>().Fanfare();
                // ReduceDamage returns true if the player was able to repair it
                if (collider.gameObject.GetComponent<Damage>().ReduceDamage(repairAmount))
                {
                    screenShake.Shake();
                    towerHP.Increase();
                    scoreManager.IncreaseScore(repairScoreReward, towerHP.towerHP);
                    Score.score = scoreManager.score;
                }
            }
        }
    }
}
