using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoordinatesText : MonoBehaviour
{
    GPSManager GPS;
    ButtonController BC;
    public TextMeshProUGUI coordinates;
    public TextMeshProUGUI savedCoordinates;

    // instantiates the different classes
    private void Start()
    {
        GPS = GPSManager.Instance;
        BC = ButtonController.Instance;
    }

    // displays the current coordinates on the screen
    private void Update()
    {
        coordinates.text = "Latitude:" + GPS.latitude.ToString() + "   Longitude:" + GPS.longitude.ToString();

        savedCoordinates.text = "Latitude:" + BC.savedLatitude.ToString() + "   Longitude:" + BC.savedLongitude.ToString();
    }
}
