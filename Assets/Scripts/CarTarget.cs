using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTarget : MonoBehaviour
{
    public GameObject car;

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position;
    }
}
