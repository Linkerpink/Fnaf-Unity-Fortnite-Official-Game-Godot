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

    [SerializeField] private GameObject camMonitor;
    [SerializeField] private float camMonitorAnimationSpeed = 0.05f;

    private int currentCam;

    private void Awake()
    {
        camChangeStaticAnimator = GameObject.Find("Cam Change Static").GetComponent<Animator>();
    }

    private void Start()
    {
        currentCam = 0;

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

            //Animations
            rawImage.transform.localScale = Vector3.Slerp(rawImage.transform.localScale, new Vector3(1, 1, 1), camMonitorAnimationSpeed);
            rawImage.transform.localPosition = Vector3.Slerp(rawImage.transform.localPosition, new Vector3(0, 0, 0), camMonitorAnimationSpeed);

            camMonitor.transform.localScale = Vector3.Slerp(camMonitor.transform.localScale, new Vector3(1, 1, 1), camMonitorAnimationSpeed);
            camMonitor.transform.localPosition = Vector3.Slerp(camMonitor.transform.localPosition, new Vector3(0, 0, 0), camMonitorAnimationSpeed);
        }
        else
        {
            cameraSystem.SetActive(false);

            //Animations
            rawImage.transform.localScale = Vector3.Slerp(rawImage.transform.localScale, new Vector3(1, 0, 1), camMonitorAnimationSpeed);
            rawImage.transform.localPosition = Vector3.Slerp(rawImage.transform.localPosition, new Vector3(0, -600, 0), camMonitorAnimationSpeed);

            camMonitor.transform.localScale = Vector3.Slerp(camMonitor.transform.localScale, new Vector3(1, 0, 1), camMonitorAnimationSpeed);
            camMonitor.transform.localPosition = Vector3.Slerp(camMonitor.transform.localPosition, new Vector3(0, -600, 0), camMonitorAnimationSpeed);
        }
    }

    public void ChangeEnableCameras()
    {
        enableCameras = !enableCameras;
    }

    public void ChangeCamera(int cam)
    {
        currentCam = cam;

        Button button = GetComponent<Button>();
        
        camChangeStaticAnimator.SetTrigger("ChangeCam");

        for (int i = 0; i < allCameras.Length; i++) 
        {
            allCameras[i].SetActive(false); 
        }

        allCameras[cam].SetActive(true);
        rawImage.texture = cameraArray[cam];
    }

    private IEnumerator camDisableDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        cameraSystem.SetActive(false);
    }
}
