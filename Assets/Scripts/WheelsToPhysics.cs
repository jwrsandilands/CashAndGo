using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsToPhysics : MonoBehaviour
{
    public WheelCollider wheel;
    public GameObject slipPrefab;
    public float rotationAngle = 0.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //define the raycast collision hit point
        RaycastHit hit;
        //Find the centerpoint of the wheel collider
        Vector3 colliderCP = wheel.transform.TransformPoint(wheel.center);

        //use the raycaster-- if it hits set it to the hit point, if it doesn't then set it to the suspension.
        if(Physics.Raycast(colliderCP, -wheel.transform.right, out hit, 0.1f * (wheel.suspensionDistance + wheel.radius)))
        {
            transform.position = hit.point + (wheel.transform.right /2);
        }
        else
        {
            transform.position = colliderCP - (wheel.transform.right * (0.1f * wheel.suspensionDistance));
        }

        //set the wheel's rotation to the rotation of the collider
        //transform.rotation = wheel.transform.rotation * Quaternion.Euler(0, -rotationAngle, 0);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, wheel.steerAngle - transform.localEulerAngles.z - 90, transform.localEulerAngles.z);

        //transform.forward = transform.up * wheel.steerAngle;
        //rotationAngle += wheel.rpm * (360 / 60) * Time.deltaTime;
        transform.Rotate(0, (wheel.rpm / 60 * 360 * Time.deltaTime), 0);

        //OPTIONAL - MIGHT USE LATER
        //get the collision point of the wheel
        //WheelHit wheelHit;
        //wheel.GetGroundHit(out wheelHit);

        //create the slip prefab when slipping value it more than 1.5
        //if(Mathf.Abs(wheelHit.sidewaysSlip) > 1.5)
        //{
        //    if (slipPrefab)
        //    {
        //        Instantiate(slipPrefab, wheelHit.point, Quaternion.identity);
        //    }
        //}
    }
}
