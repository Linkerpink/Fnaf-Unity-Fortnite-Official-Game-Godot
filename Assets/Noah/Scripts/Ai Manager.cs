using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiManager : MonoBehaviour
{
    private GameObject bonnie;
    private GameObject chica;
    private GameObject freddy;
    private GameObject foxy;

    public Dictionary<string, GameObject> points = new Dictionary<string, GameObject>();
    [SerializeField] GameObject pointManager;

    private void Start()
    {
        foreach (Transform point in pointManager.transform) 
        {
            points.Add(point.name, point.gameObject);
        }

        foreach(var point in points.Keys)
        {
            Debug.Log(point);
        }


    }
}
