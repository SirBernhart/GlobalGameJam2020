using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{

    [SerializeField]static public int nChunks = 0;
    [SerializeField]static public int dificuldade = 1;
    [SerializeField]static public float velocidade = 0.7f;

    private static float frameSize = 10.81192f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nChunks <= 7)
        {
            dificuldade = 1;
            velocidade = frameSize / 6;
            return;
        }
        if(nChunks <= 15)
        {
            dificuldade = 2;
            velocidade = frameSize / 5;
            return;
        }
        if(nChunks <= 23)
        {
            dificuldade = 3;
            velocidade = frameSize / 5;
            return;
        }
        if(nChunks <= 43)
        {
            dificuldade = 4;
            velocidade = frameSize / 4;
            return;
        }
        dificuldade = 5;
        velocidade = frameSize / 3;
        return;
        
    }
}
