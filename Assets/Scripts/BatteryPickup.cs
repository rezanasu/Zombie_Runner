using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float intensityAmount = 1f;

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLightSystem>().AddLightIntensity(intensityAmount);
            Destroy(gameObject);
        }
    }
}
