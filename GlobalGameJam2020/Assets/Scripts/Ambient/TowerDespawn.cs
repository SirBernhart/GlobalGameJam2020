using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDespawn : MonoBehaviour
{
    [HideInInspector]
    public ChunkGenerator generatorRef;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.gameObject.GetComponent<SpriteRenderer>().sprite.bounds);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //print(other.name);
        string tag = other.gameObject.tag;
        if(tag == "towerSpawn")
        {
            generatorRef.nextSpawn();
        }
        if(tag == "towerDespawn")
        {
            if(this.gameObject.name != "Tower base(Clone)")
            {
                print("Destroy");
                Destroy(this.gameObject);
            }
            else
            {
                StartCoroutine(TowerBaseDestroySentence());
            }
        } 
    }

    private IEnumerator TowerBaseDestroySentence()
    {
        while (true)
        {
            if(transform.localPosition.y == -400)
            {
                Destroy(gameObject);
            }
        }
    }
}
