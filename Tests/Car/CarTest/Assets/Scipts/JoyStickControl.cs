using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickControl : MonoBehaviour
{
    public WheelCollider[] wheelsColl;

    public Transform[] wheelsTransform;

    public FixedJoystick joystick;

    float torque = 100;
    float angle = 30;

    private void FixedUpdate()
    {
        for (int i = 0; i < wheelsColl.Length; i++)
        {
            if(i==0||i==1)
            {
                wheelsColl[i].steerAngle = joystick.Horizontal * angle;
            }

            wheelsColl[i].motorTorque = joystick.Vertical * torque;
            var rot = transform.rotation;
            var pos = transform.position;
            wheelsColl[i].GetWorldPose(out pos, out rot);

            wheelsTransform[i].position = pos;
            wheelsTransform[i].rotation = rot;

        }
    }
}
