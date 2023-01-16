using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public AudioSource audioSource;
    System.Random rnd = new System.Random();

    void OnTriggerEnter(Collider other)
    {
        int val = rnd.Next(5);
        
        if (other.tag == "Player" && !audioSource.isPlaying && val == 0)
        {
            audioSource.volume = 0.8f; 
            audioSource.Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(FadeAudioSource.StartFade(audioSource, 2, 0));
        }
    }
}
