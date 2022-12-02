using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCarro4x4 : MonoBehaviour
{
    public WheelCollider[] rodas;
    public float torque;

    private void Update()
    {
        // Essa força deve ser aplicada em cada roda
        float t = Input.GetAxis("Vertical") * torque;
        for(int i = 0; i < rodas.Length; i++)
        {
            rodas[i].motorTorque = t;
        }
    }
}
