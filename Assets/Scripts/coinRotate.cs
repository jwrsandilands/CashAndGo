using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotate : MonoBehaviour
{
    public float rotationSpeed = 60;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
    }
}
