using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveUp : MonoBehaviour
{

    public WheelCollider[] wheelsColl;

    public Transform[] wheelsTransform;

    float torque = 0;

    private void FixedUpdate()
    {
        for(int i = 0; i< wheelsColl.Length;i++)
        {
            wheelsColl[i].motorTorque = torque;
            var rot = transform.rotation;
            var pos = transform.position;
            wheelsColl[i].GetWorldPose(out pos, out rot);

            wheelsTransform[i].position = pos;
            wheelsTransform[i].rotation = rot;

        }
    }

    public void OnDown(Button btn)
    {
        if(btn.name == "up")
        {
            torque = 100;
        }

        if(btn.name == "down")
        {
            torque = -100;
        }
    }


    public void OnUp()
    {
        torque = 0;
    }

}
