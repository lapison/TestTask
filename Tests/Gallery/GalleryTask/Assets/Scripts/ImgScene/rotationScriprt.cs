using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotationScriprt : MonoBehaviour
{
    public RectTransform backGround;
    public CanvasScaler scaler;


    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        scaler.referenceResolution = new Vector2(Screen.width, Screen.height);
        backGround.sizeDelta = new Vector2(Screen.width, Screen.height);
    }

    private void Update()
    {
        switch(Input.deviceOrientation)
        {
            case (DeviceOrientation.FaceUp):
                Screen.orientation = ScreenOrientation.Portrait;
                scaler.referenceResolution = new Vector2(Screen.width, Screen.height);
                backGround.sizeDelta = new Vector2(Screen.width, Screen.height);

                break;

            case (DeviceOrientation.LandscapeLeft):
                Screen.orientation = ScreenOrientation.LandscapeLeft;
                scaler.referenceResolution = new Vector2(Screen.width, Screen.height);
                backGround.sizeDelta = new Vector2(Screen.width, Screen.height);

                break;

            case (DeviceOrientation.LandscapeRight):
                Screen.orientation = ScreenOrientation.LandscapeRight;
                scaler.referenceResolution = new Vector2(Screen.width, Screen.height);
                backGround.sizeDelta = new Vector2(Screen.width, Screen.height);

                break;
        }
    }
}
