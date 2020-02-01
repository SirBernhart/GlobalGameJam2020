using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
    public Transform  parentTransform;
    public int flawsPerSpawn;
    public GameObject chunk;
    public GameObject flaw;
    public Transform leftBound;
    public Transform rightBound;
    public Transform upperBound;
    public Transform lowerBound;

    private Transform lastSpawn;
    // Start is called before the first frame update
    void Start()
    {
        spawnChunk(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnChunk(int nflaws)
    {
        GameObject newChunk = Instantiate(chunk,parentTransform.position,Quaternion.identity,parentTransform);
        lastSpawn = newChunk.GetComponent<Transform>();
        //lastSpawn.GetComponent<TowerDespawn>().generatorRef = this;

        Bounds chunkBound = newChunk.GetComponent<SpriteRenderer>().bounds;

        float chunkHeight = upperBound.position.y - lowerBound.position.y;
        float chunkWidth = chunkBound.max.x - chunkBound.min.x;

        if (nflaws > 0)
        {
            float segSize = chunkHeight / nflaws;
            for(int i=0;i<nflaws; i++)
            {
                float x = Random.Range(leftBound.position.x,rightBound.position.x); 
                float y = Random.Range(lowerBound.position.y,lowerBound.position.y + segSize);
                y+=i * segSize;
                Instantiate(flaw,new Vector3(x,y,0),Quaternion.identity,lastSpawn); 
            }
        }
    }
}
