using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    Outline outline;
    public string message;

    public UnityEvent onInteraction;

    public DoorSystem ja;

    // Start is called before the first frame update
    void Start()
    {
        ja = GetComponent<DoorSystem>();
        outline = GetComponent<Outline>();
        DisableOutLine();
    }

    public void Interact()
    {
        onInteraction.Invoke();
        ja.OpenDoor();
    }

    public void DisableOutLine()
    {
        outline.enabled = false;
    }

    public void EnableOutLine()
    {
        outline.enabled = true; 
    }

}
