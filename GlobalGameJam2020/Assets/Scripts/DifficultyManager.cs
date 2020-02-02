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
        if(nChunks <= 4)
        {
            dificuldade = 1;
            velocidade = frameSize / 6;
            return;
        }
        if(nChunks <= 9)
        {
            dificuldade = 2;
            velocidade = frameSize / 5;
            return;
        }
        if(nChunks <= 16)
        {
            dificuldade = 3;
            velocidade = frameSize / 5;
            return;
        }
        if(nChunks <= 26)
        {
            dificuldade = 3;
            velocidade = frameSize / 4.5f;
            return;
        }
        if(nChunks <= 36)
        {
            dificuldade = 4;
            velocidade = frameSize / 4.5f;
        }
        if(nChunks <= 51)
        {
            dificuldade = 4;
            velocidade = frameSize / 4;
        }
        if(nChunks <= 80)
        {
            dificuldade = 5;
            velocidade = frameSize / 4;
        }
        dificuldade = 5;
        velocidade = frameSize / 3.5f;
        return;
        
    }
}
