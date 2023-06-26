using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControl : MonoBehaviour
{
    public GameObject buttons;
    public GameObject scrolls;

    public GameObject car;

    bool but = false;
    

    public void click()
    {
        if (!this.but)
        {
            buttons.SetActive(false);
            scrolls.SetActive(true);
            car.GetComponent<MoveUp>().enabled = false;
            car.GetComponent<MoveAngle>().enabled = false;
            car.GetComponent<JoyStickControl>().enabled = true;
            this.but = true;
        }
        else
        {
            scrolls.SetActive(false);
            buttons.SetActive(true);
            car.GetComponent<JoyStickControl>().enabled = false;
            car.GetComponent<MoveUp>().enabled = true;
            car.GetComponent<MoveAngle>().enabled = true;
            this.but = false;
        }
    }
}
