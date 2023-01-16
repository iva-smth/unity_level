using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Interactable;

public class PlayerInteract : MonoBehaviour
{
    public Camera camera;
    public float distance = 3.0f;
    public LayerMask mask;

    public UI playerUI;

    void Start() 
    {
        playerUI = GetComponent<UI>();
    }

    void Update() 
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(ray.origin, ray.direction * distance);

        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, distance, mask)) 
        {
            if(hitInfo.collider.GetComponent<Interactable>() != null) 
            {
                playerUI.UpdateText(hitInfo.collider.GetComponent<Interactable>().message);
            }
        }
    }
}
