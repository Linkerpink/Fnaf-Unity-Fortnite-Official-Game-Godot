using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CameraManager : MonoBehaviour
{
    private bool enableCameras = false;
    private bool canEnableCameras = true;

    [SerializeField] private Button camMonitorButton;
    [SerializeField] private GameObject cameraSystem;

    //Camera Render Textures
    [SerializeField] private GameObject cam1ART;
    [SerializeField] private GameObject cam1BRT;

    private enum Cameras
    {
        cam1A,
        cam1B,
    }

    private Cameras currentCamera;

    private void Update()
    {
        

        switch (currentCamera)
        {
            case Cameras.cam1A:
                cam1ART.SetActive(true);
                cam1BRT.SetActive(false);
                break;

            case Cameras.cam1B:
                cam1ART.SetActive(false);
                cam1BRT.SetActive(true);
                break;

            default:
                break;
        }

        if (Input.GetKeyDown(KeyCode.S)) 
        {
            ChangeEnableCameras();
        }

        if (enableCameras)
        {
            cameraSystem.SetActive(true);
        }
        else
        {
            cameraSystem.SetActive(false);
        }
    }

    public void ChangeEnableCameras()
    {
        enableCameras = !enableCameras;
    }

    public void ChangeCam1A()
    {
        currentCamera = Cameras.cam1A;
    }

    public void ChangeCam1B() 
    {
        currentCamera = Cameras.cam1B;
    }
}
