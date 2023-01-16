using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Interactable
{
    public GameObject[] torches = new GameObject[6];
    public AudioClip audio;
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        message = string.Empty;
    }

    bool playernear = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playernear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playernear = false;
        }
    }
    void Update()
    {
        if (torches[0].activeSelf && torches[1].activeSelf && torches[2].activeSelf && torches[3].activeSelf && !torches[4].activeSelf && !torches[5].activeSelf)
        {
            if (gameObject.TryGetComponent<Rigidbody>(out var Rigidbody) == false)
            {
                Rigidbody gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>();
                gameObjectsRigidBody.mass = 1;
                audioSource.PlayDelayed(0.8f);
            }
        }

        if (playernear && gameObject.GetComponent<Rigidbody>())
        {
            message = "Press F to collect";
            if (Input.GetKeyDown(KeyCode.F))
            {
                Destroy(gameObject);
            }
        }
    }
}
