using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureFall : MonoBehaviour
{
    System.Random rnd = new System.Random();
    int count = 0;
    public AudioClip audio;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerExit(Collider collider)
    {
        if(collider.transform.CompareTag("Player"))
            count += 1;
    }
    void Update()
    {
        int val = rnd.Next(1, 500);
        if (val == 1 && count > 3 && gameObject.TryGetComponent<Rigidbody>(out var Rigidbody) == false)
        {
            Rigidbody gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>();
            gameObjectsRigidBody.mass = 1;
            audioSource.PlayDelayed(0.4f);
        }
    }
}
