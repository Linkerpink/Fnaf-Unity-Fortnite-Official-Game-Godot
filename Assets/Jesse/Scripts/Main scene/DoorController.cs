using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Door Door;
    private CameraManager cameraManager;

    private void Awake()
    {
        cameraManager = GameObject.Find("Camera Manager").GetComponent<CameraManager>();
    }

    private void OnMouseDown()
    {
        if (!cameraManager.enableCameras)
        {
            Door.isOpen = !Door.isOpen;
        }
    }
}
