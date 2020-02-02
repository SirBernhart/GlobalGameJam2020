using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
    public Transform  parentTransform;
    public int flawsPerSpawn;
    public GameObject[] towerPieces;
    public ScoreSO Score;


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
        DifficultyManager.nChunks += 1;
        Score.floor = DifficultyManager.nChunks;
        GameObject newChunk = (GameObject)Instantiate(chunk,parentTransform.position,Quaternion.identity,parentTransform);
        if(newChunk != null)
        {
            newChunk.GetComponent<TowerDespawn>().generatorRef = this;
        }
    }

    public void nextSpawn()
    {

        if(DifficultyManager.nChunks<8)/*Os primeiros 8 andares são predeterminados*/
        {
            spawnChunk(towerPieces[DifficultyManager.nChunks]);
        }
        else
        {
            spawnChunk(towerPieces[Random.Range(2,towerPieces.Length)]);
        }
    }
}
