using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camscripts : MonoBehaviour
{
    public Transform playerCam;
    public float rotateSpeed;
    public int clampValue;

    public bool movingLeft;
    public bool movingRight;

    private void Update()
    {
        if(movingLeft == true) 
        {
            if(playerCam.localRotation == Quaternion.Euler(0, -clampValue, 0))
            {

            }
            else
            {
                playerCam.Rotate(0, -rotateSpeed, 0);
            }
        }

        if(movingRight == true)
        {
            if(playerCam.localRotation == Quaternion.Euler(0, clampValue, 0))
            {

            }
            else
            {
                playerCam.Rotate(0, rotateSpeed, 0);
            }
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
