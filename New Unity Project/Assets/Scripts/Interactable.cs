using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string message;

    protected virtual void Interact()
    {

    }

    private void BaseInteract() 
    {
        Interact();

    }
}
