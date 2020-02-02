using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlaySound(AudioSource UI)
    {
        UI.Play();
    }
}
