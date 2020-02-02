using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizerVocal : MonoBehaviour
{


     public AudioSource randomSound;
 
     public AudioClip[] Frases
     ;
     public AudioClip ClipAtual;
     //public int index;


    // Start is called before the first frame update
     public void OnEnable() {

        randomSound.clip = Frases[Random.Range(0, Frases.Length)];
        randomSound.Play ();
        // CallAudio ();
    }



       public void RandomSoundness()
     {

     }
}
