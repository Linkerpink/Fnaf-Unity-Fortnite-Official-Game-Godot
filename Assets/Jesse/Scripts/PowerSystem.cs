using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSystem : Door
{
    public float powerCapacity = 100;
    public float powerDrainSpeed = 5;

    public float currentPower;

    private void Start()
    {
        currentPower = powerCapacity;
    }

    private void Update()
    {
        Debug.Log(currentPower);
        if(isOpen == true)
        {
            currentPower -= powerDrainSpeed * Time.deltaTime;
            //currentPower = Mathf.Clamp(powerCapacity, 0, currentPower);

            if (powerCapacity <= 0)
            {
                isOpen = false;
            }
        }
        else
        {
            //powerDrainSpeed = 0;
        }
        
        
    }
}
