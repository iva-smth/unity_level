using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : Interactable
{
    public GameObject mapImage;
    bool isvisible = false;
    // Start is called before the first frame update
    void Start()
    {
        
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
    // Update is called once per frame
    void Update()
    {
        if (playernear)
        {
            if (Input.GetMouseButtonDown(0))
                if (!isvisible)
                {
                    mapImage.SetActive(true);
                    isvisible = true;
                    message = "Right click to exit";
                }
            if (Input.GetMouseButtonDown(1))
                if (isvisible)
                {
                    mapImage.SetActive(false);
                    isvisible = false;
                    message = "Left click to inspect";
                }
        }
    }
}

