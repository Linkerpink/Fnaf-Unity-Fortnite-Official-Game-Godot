using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject Light;

    [SerializeField] private Vector3 openPos;
    [SerializeField] private Vector3 closePos;

    [SerializeField] private float doorSpeed;

    public bool isOpen;
    public bool isOn;

    void Start()
    {
        transform.position = openPos;
        isOpen = true;

        ChangeLights();
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            if (transform.position != openPos)
            {
                if (Vector3.Distance(transform.position, openPos) <= 0.5f)
                {
                    transform.position = openPos;
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, openPos, doorSpeed * Time.deltaTime);
                }
            }
        }
        else
        {
            if (transform.position != closePos)
            {
                if (Vector3.Distance(transform.position, closePos) <= 0.5f)
                {
                    transform.position = closePos;
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, closePos, doorSpeed * Time.deltaTime);
                }
            }
        }
    }

    public void ChangeLights()
    {
        isOn = !isOn;

        if(isOn)
        {
            Light.SetActive(true);
        }
        else
        {
            Light.SetActive(false);
        }
    }
}
