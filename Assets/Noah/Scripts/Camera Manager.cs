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
    [SerializeField] private RawImage rawImage;
    [SerializeField] private RenderTexture[] cameraArray;
    

    private void Update()
    {
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

    public void ChangeCamera(int cam)
    {
        rawImage.texture = cameraArray[cam];
    }
}
