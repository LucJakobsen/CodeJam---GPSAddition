using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : SingletonPattern<ButtonController>
{
    public Button button;
    public float savedLatitude;
    public float savedLongitude;

    // unity event to make the button function properly
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    // saves the last read coordinates as variables
    void OnButtonClick()
    {
        savedLatitude = Input.location.lastData.latitude;
        savedLongitude = Input.location.lastData.longitude;
    }
}
