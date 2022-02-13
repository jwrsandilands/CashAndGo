using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    //position variables and turn speed
    public Transform carPos;
    public Transform mousePos;
    public float maxTurnAngle = 20;

    //axel variables (based on unity demo car code)
    public List<AxleInfo> axleInfos;
    public float maxMotorTorque;
    public float maxSteeringAngle;

    // Update is called once per frame
    void Update()
    {
        //check if paused
        if (!PauseControl.pauseGame && !PauseControl.gameOver)
        {
            //find angle between car and mouse
            Vector3 turnVector = mousePos.position - carPos.position;
            Vector3 carForward = transform.forward;

            float carAngle = Vector3.Angle(carForward, turnVector);
            Vector2 cross = Vector3.Cross(carForward, turnVector);
            if (cross.y < 0)
            {
                carAngle = -carAngle;
            }

            float steerAngle;
            if (carAngle < -maxTurnAngle)
            {
                steerAngle = -maxTurnAngle;
            }
            else if (carAngle > maxTurnAngle)
            {
                steerAngle = maxTurnAngle;
            }
            else
            {
                steerAngle = carAngle;
            }
            steerAngle = steerAngle / maxTurnAngle;

            //Dedicate turning and driving wheels (based on unity demo car code)
            float motor;
            float drive = 0;

            if (Input.GetMouseButton(0))
            {
                drive = 1;
            }
            else if (Input.GetMouseButton(1))
            {
                drive = -1;
            }
            drive = Mathf.Lerp(drive, 0, 0.03f);
            motor = maxMotorTorque * drive;

            float steering = maxSteeringAngle * steerAngle;

            foreach (AxleInfo axleInfo in axleInfos)
            {
                if (axleInfo.steering)
                {
                    axleInfo.leftWheel.steerAngle = steering;
                    axleInfo.rightWheel.steerAngle = steering;
                }
                if (axleInfo.motor)
                {
                    axleInfo.leftWheel.motorTorque = motor;
                    axleInfo.rightWheel.motorTorque = motor;
                }
            }
        }
    }

    //for the car controller variables (based on unity demo car code)
    [System.Serializable]
    public class AxleInfo
    {
        public WheelCollider leftWheel;
        public WheelCollider rightWheel;
        public bool motor;
        public bool steering;
    }
}

