using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CameraManager : MonoBehaviour
{
    public bool enableCameras = false;

    [SerializeField] private Button camMonitorButton;
    [SerializeField] private GameObject cameraSystem;
    [SerializeField] private GameObject[] allCameras;

    //Camera Render Textures
    [SerializeField] private RawImage rawImage;
    [SerializeField] private RenderTexture[] cameraArray;

    private Animator camChangeStaticAnimator;

    private void Awake()
    {
        camChangeStaticAnimator = GameObject.Find("Cam Change Static").GetComponent<Animator>();
    }

    private void Start()
    {
        for (int i = 0; i < allCameras.Length; i++)
        {
            allCameras[i].SetActive(false);
        }

        allCameras[0].SetActive(true);
    }

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
        camChangeStaticAnimator.SetTrigger("ChangeCam");

        for (int i = 0; i < allCameras.Length; i++) 
        {
            allCameras[i].SetActive(false); 
        }

        allCameras[cam].SetActive(true);
        rawImage.texture = cameraArray[cam];
    }
}
