using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScreen : MonoBehaviour
{
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
