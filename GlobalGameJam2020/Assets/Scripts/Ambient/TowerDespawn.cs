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
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            print("Destroy");
            Destroy(this.gameObject);
        }
    }
}
