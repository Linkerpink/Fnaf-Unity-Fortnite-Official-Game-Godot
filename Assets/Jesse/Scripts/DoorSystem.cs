using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorStates
{
    open,
    closed,
}

public class DoorSystem : MonoBehaviour
{

    private Animator animator;

    private DoorStates doorStates;

    private void Awake()
    {
        animator = GetComponent<Animator>();    
    }


    // Update is called once per frame
    void Update()
    {
        if(doorStates == DoorStates.open)
        {
            CloseDoor();
        }

        if(doorStates == DoorStates.closed)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        animator.SetTrigger("Door open");
    }

    private void CloseDoor()
    {
        animator.SetTrigger("Door close");
    }
}
