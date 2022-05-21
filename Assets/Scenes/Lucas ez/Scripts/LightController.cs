using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    FlashLightManager FLM;
    GPSManager GPS;

    private void Update()
    {
        LocationChecker();
    }

    // m�ske bruge switch? men ville jeg s� ik sku bruge en switch for b�de latitude?
    private void LocationChecker()
    {
        if (GPS.latitude > GPS.savedLatitude)
        {
            FLM.FL_Start();
        }
        else if (GPS.latitude < GPS.savedLatitude)
        {
            FLM.FL_Start();
        }
        else if (GPS.longitude > GPS.savedLongitude)
        {
            FLM.FL_Start();
        }
        else if (GPS.longitude < GPS.savedLongitude)
        {
            FLM.FL_Start();
        }
        else
        {
            FLM.FL_Stop();
        }
    }
        
}
