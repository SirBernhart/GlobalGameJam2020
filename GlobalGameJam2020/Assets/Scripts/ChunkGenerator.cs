using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
    public Transform  parentTransform;
    public int flawsPerSpawn;
    public GameObject[] towerPieces;


    private int floorsSpawned;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnChunk(GameObject chunk)
    {
        Debug.Log("Spawn");
        floorsSpawned+=1;
        GameObject newChunk = (GameObject)Instantiate(chunk,parentTransform.position,Quaternion.identity,parentTransform);
        if(newChunk != null)
        {
            newChunk.GetComponent<TowerDespawn>().generatorRef = this;
            newChunk.GetComponent<DamageSpawner>().difficulty = 4;//(Nova classe?)
        }
    }

    public void nextSpawn()
    {

        if(floorsSpawned<8)/*Os primeiros 8 andares são predeterminados*/
        {
            spawnChunk(towerPieces[floorsSpawned]);
        }
        else
        {
            spawnChunk(towerPieces[Random.Range(0,towerPieces.Length)]);
        }
    }
}
