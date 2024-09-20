using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiManager : MonoBehaviour
{
    private GameObject bonnie;
    private GameObject chica;
    private GameObject freddy;
    private GameObject foxy;

    //public Dictionary<string, GameObject> points = new Dictionary<string, GameObject>();
    [SerializeField] private Transform cam_1a_bonnie, cam_1a_chica, cam_1a_freddy, cam_1c_foxy;

    private void Awake()
    {
        bonnie = GameObject.Find("Bonnie");
        chica = GameObject.Find("Chica");
        freddy = GameObject.Find("Freddy");
        foxy = GameObject.Find("Foxy");
    }

    private void Start()
    {
        SetSpawnPositions();

        /*foreach (Transform point in pointManager.transform) 
        {
            points.Add(point.name, point.gameObject);
        }

        foreach(var point in points.Keys)
        {
            Debug.Log(point);
        }

        */
    }

    private void SetSpawnPositions()
    {
        bonnie.transform.position = cam_1a_bonnie.transform.position;
        chica.transform.position = cam_1a_chica.transform.position;
        freddy.transform.position = cam_1a_freddy.transform.position;
        foxy.transform.position = cam_1c_foxy.transform.position;
    }
}
