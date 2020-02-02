using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DifficultyManager : MonoBehaviour
{

    [SerializeField]static public int nChunks = 0;
    [SerializeField]static public int dificuldade = 1;
    [SerializeField]static public float velocidade = 0.7f;
    [SerializeField] private TextMeshProUGUI floorCounter;

    private static float frameSize = 10.81192f;

    // Start is called before the first frame update
    void Start()
    {
        //nChunks = 0;
        dificuldade = 1;
        velocidade = 0.7f;
    }

    // Update is called once per frame
    void Update()
    {
        floorCounter.text = nChunks.ToString();

        // Intro
        if (nChunks <= 3)
        {
            dificuldade = 1;
            velocidade = frameSize / 5;
            return;
        }
        if (nChunks <= 5)
        {
            dificuldade = 2;
            velocidade = frameSize / 5;
            return;
        }
        // Fácil
        if (nChunks <= 7)
        {
            dificuldade = 3;
            velocidade = frameSize / 5;
            return;
        }
        if (nChunks <= 9)
        {
            dificuldade = 3;
            velocidade = frameSize / 4.5f;
            return;
        }
        if (nChunks <= 11)
        {
            dificuldade = 4;
            velocidade = frameSize / 4.5f;
            return;
        }
        if (nChunks <= 13)
        {
            dificuldade = 4;
            velocidade = frameSize / 4;
            return;
        }
        if (nChunks <= 15)
        {
            dificuldade = 5;
            velocidade = frameSize / 4;
            return;
        }
        // Médio
        if (nChunks <= 20)
        {
            dificuldade = 5;
            velocidade = frameSize / 3.5f;
            return;
        }
        if (nChunks <= 25)
        {
            dificuldade = 6;
            velocidade = frameSize / 3.5f;
            return;
        }
        // Difícil
        if (nChunks <= 30)
        {
            dificuldade = 6;
            velocidade = frameSize / 3f;
            return;
        }
        if (nChunks <= 35)
        {
            dificuldade = 7;
            velocidade = frameSize / 3f;
            return;
        }
        // Duro de matar / Inferno / Elite / Somente os brabo
        if (nChunks <= 50)
        {
            dificuldade = 7;
            velocidade = frameSize / 2.5f;
            return;
        }
        dificuldade = 7;
        velocidade = frameSize / 2f;
        return;
    }
}
