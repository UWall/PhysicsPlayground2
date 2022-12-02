using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartControllr : MonoBehaviour
{
    public List<EixoInfo> eixosInfo; 
    public float maxMotorTorque; 
    public float maxSteeringAngle; 
    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        foreach (EixoInfo eixoInfo in eixosInfo)
        {
            if (eixoInfo.steering)
            {
                eixoInfo.leftWheel.steerAngle = steering;
                eixoInfo.rightWheel.steerAngle = steering;
            }
            if (eixoInfo.motor)
            {
                eixoInfo.leftWheel.motorTorque = motor;
                eixoInfo.rightWheel.motorTorque = motor;
            }
        }
    }
}
[System.Serializable]
public class EixoInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; 
    public bool steering; 
}

