using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMass : MonoBehaviour
{
    //variables
    public Transform massPosition;
    public Rigidbody carCollider;

    // Start is called before the first frame update
    void Start()
    {
        carCollider.centerOfMass = massPosition.position;
    }
}
