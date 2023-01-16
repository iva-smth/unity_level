using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Floor : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] _clip = new AudioClip[3];
    System.Random rnd = new System.Random();

    private void OnTriggerEnter(Collider collider)
    {
        int val = rnd.Next(3);
        if (collider.transform.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(_clip[val], transform.position);
        }
    }
}
