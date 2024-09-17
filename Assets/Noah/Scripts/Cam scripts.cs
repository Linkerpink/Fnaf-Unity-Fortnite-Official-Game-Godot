using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camscripts : MonoBehaviour
{
    public Transform playerCam;
    public float rotateSpeed;
    public float clampValue;

    public bool movingLeft;
    public bool movingRight;

    private CameraManager cameraManager;
    private float currentYRotation = 0f;

    private void Awake()
    {
        cameraManager = GameObject.Find("Camera Manager").GetComponent<CameraManager>();
    }

    private void Update()
    {
        if (!cameraManager.enableCameras)
        {
            float rotationInput = 0f;

            if (movingLeft)
            {
                rotationInput = -rotateSpeed * Time.deltaTime;
            }

            if (movingRight)
            {
                rotationInput = rotateSpeed * Time.deltaTime;
            }

            currentYRotation += rotationInput;

            currentYRotation = Mathf.Clamp(currentYRotation, -clampValue, clampValue);

            playerCam.localRotation = Quaternion.Euler(0, currentYRotation, 0);
        }
    }

    public void rotateLeft()
    {
        movingLeft = true;
    }

    public void rotateRight()
    {
        movingRight = true;
    }

    public void stopRotateLeft()
    {
        movingLeft = false;
    }

    public void stopRotateRight()
    {
        movingRight = false;
    }
}
