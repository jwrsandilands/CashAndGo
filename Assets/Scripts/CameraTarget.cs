using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public Transform targetPoint;
    public float cameraUp = 20;
    public float cameraRight = 5;
    //public float rotateSpeed;

    void Update()
    {
        transform.LookAt(targetPoint);

        //transform.RotateAround(targetPoint.position, targetPoint.up, rotateSpeed);
        transform.position = targetPoint.position + (targetPoint.transform.up * cameraUp) + (targetPoint.transform.right * cameraRight);
        //+(targetPoint.transform.right * 4)
    }
}
