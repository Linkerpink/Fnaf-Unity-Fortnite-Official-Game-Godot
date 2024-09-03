using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public Camera cam;

    //public float camSensitivity = 100f;
    //private float originalCamSensitivity;

    private float minLook = -90f;
    private float maxLook = 90f;
    private float look = 0f;
 
    public float camSpeed = 0.01f;

    private enum CamStates
    {
        Left,
        Neutral,
        Right
    }

    private CamStates state;

    private void Awake()
    {
        //originalCamSensitivity = camSensitivity;
    }

    private void Start()
    {
        state = CamStates.Neutral;
    }

    private void Update()
    {
        Vector2 point = cam.ScreenToViewportPoint(Input.mousePosition);

        if (state == CamStates.Left)
        {
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, Quaternion.Euler(0f, -90f, 0f), camSpeed * Time.deltaTime);
        }
        else if (state == CamStates.Neutral)
        {
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, Quaternion.Euler(0f, 0f, 0f), camSpeed * Time.deltaTime);
        }
        else if (state == CamStates.Right)
        {
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, Quaternion.Euler(0f, 90f, 0f), camSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (state == CamStates.Left)
            {
                state = CamStates.Left;
            }
            else if (state == CamStates.Neutral)
            {
                state = CamStates.Left;
            }
            else if (state == CamStates.Right)
            {
                state = CamStates.Neutral;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (state == CamStates.Left)
            {
                state = CamStates.Neutral;
            }
            else if (state == CamStates.Neutral)
            {
                state = CamStates.Right;
            }
            else if (state == CamStates.Right)
            {
                state = CamStates.Right;
            }
        }

        /*
        if (point.x < 0.25)
        {
            if (state == CamStates.Left)
            {
                state = CamStates.Left;
            }
            else if (state == CamStates.Neutral)
            {
                state = CamStates.Left;
            }
            else if (state == CamStates.Right)
            {
                state = CamStates.Neutral;
            }
        }

        if (point.x > 0.75)
        {
            if (state == CamStates.Left)
            {
                state = CamStates.Neutral;
            }
            else if (state == CamStates.Neutral)
            {
                state = CamStates.Right;
            }
            else if (state == CamStates.Right)
            {
                state = CamStates.Right;
            }
        }
        */

        Debug.Log(point);

        /*
        if (Input.GetKey(KeyCode.A))
        {
            if (look > minLook)
            {
                look -= camSensitivity * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (look < maxLook)
            {
                look += camSensitivity * Time.deltaTime;
            }
        }
        */



        /*
        if (state == CamStates.Left) 
        {
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, Quaternion.Euler(0f, -90f, 0f), camSpeed);
        }
        else if (state == CamStates.Neutral)
        {
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, Quaternion.Euler(0f, 0f, 0f), camSpeed);
        }
        else if (state == CamStates.Right) 
        {
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, Quaternion.Euler(0f, 90f, 0f), camSpeed);
        }


	    if (Input.GetKeyDown(KeyCode.A))
        {
            if (state == CamStates.Left)
            {
                state = CamStates.Left;
            }
            else if (state == CamStates.Neutral)
            {
                state = CamStates.Left;
            }
            else if (state == CamStates.Right)
            {
                state = CamStates.Neutral;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (state == CamStates.Left)
            {
                state = CamStates.Neutral;
            }
            else if (state == CamStates.Neutral)
            {
                state = CamStates.Right;
            }
            else if (state == CamStates.Right)
            {
                state = CamStates.Right;
            }
        }

        */
    }
}
