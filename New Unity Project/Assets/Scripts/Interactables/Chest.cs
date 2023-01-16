using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactable 
{
    bool playernear = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            message = "Press F to collect";
            playernear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            message = "That's a chest!";
            playernear = false;
        }
    }

    void Update()
    {
        if (playernear)
        {
           if (Input.GetKeyDown(KeyCode.F)) 
           {
                Destroy(gameObject);
           }
        }
    }
}
