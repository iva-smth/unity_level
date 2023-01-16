using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : Interactable
{
    public GameObject fire;
    bool islitten = false;
    bool playernear = false;
    // Start is called before the first frame update
    void Start()
    {
        fire.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        playernear = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playernear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && playernear == true)
        {
            if (islitten == false)
            {
                fire.SetActive(true);
                islitten = true;
                message = "Press G to put out";
            }
         }

        if (Input.GetKeyDown(KeyCode.G) && playernear == true)
        {
            if (islitten == true)
            {
                fire.SetActive(false);
                islitten = false;
                message = "Press F to light up";
            }

        }
    }
}
