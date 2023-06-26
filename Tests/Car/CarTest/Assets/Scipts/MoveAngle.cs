using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveAngle : MonoBehaviour
{

    public WheelCollider[] wheelsColl;

    public Transform[] wheelsTransform;

    float angle = 0;
    float cur_angle;
    private void FixedUpdate()
    {
        for (int i = 0; i < wheelsColl.Length; i++)
        {
            wheelsColl[i].steerAngle = cur_angle;
        }
    }

    public void OnDown(Button btn)
    {
        if (btn.name == "right")
        {
            angle = 30;
            StopAllCoroutines();
            StartCoroutine(Rotate());
        }

        if (btn.name == "left")
        {
            angle = -30;
            StopAllCoroutines();
            StartCoroutine(Rotate());
        }
    }


    public void OnUp()
    {
        angle = 0;
        StopAllCoroutines();
        StartCoroutine(Rotate());
    }

    IEnumerator Rotate()
    {
        switch(this.angle)
        {

            case 0:
                if(cur_angle<0)
                {
                    while(cur_angle<0)
                    {
                        cur_angle += 1f;

                        yield return 0;
                    }
                }
                else
                {
                    while (cur_angle > 0)
                    {
                        cur_angle -= 1f;

                        yield return 0;
                    }
                }
                break;

            case 30:
                while(cur_angle<angle)
                {
                    cur_angle += 1f;

                    yield return 0;
                }
                break;

            case -30:
                while (cur_angle > angle)
                {
                    cur_angle -= 1f;

                    yield return 0;
                }
                break;
        }
    }

}
