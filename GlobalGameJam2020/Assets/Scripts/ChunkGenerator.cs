using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
    public Transform  parentTransform;
    public int flawsPerSpawn;
    public GameObject chunk;
    public SpriteRenderer chunkRenderer;
    public GameObject flaw;
    public SpriteRenderer flawRenderer;

    void spawnChunk(int nflaws)
    {
        Instantiate(chunk,parentTransform);
        Bounds chunkBounds = chunkRenderer.bounds;
        Bounds flawBounds = flawRenderer.bounds;
        for(int i=0;i<nflaws; i++)
        {
            float x = Random.Range(chunkBounds.min.x + flawBounds.center.x, chunkBounds.max.x - flawBounds.center.x); 
            float y = Random.Range(chunkBounds.min.y + flawBounds.center.y, chunkBounds.max.y - flawBounds.center.y);
            Instantiate(flaw,new Vector3(x,y,0),Quaternion.identity,parentTransform); 
        }
    }
}
