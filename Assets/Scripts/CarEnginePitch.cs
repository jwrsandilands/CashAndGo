using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnginePitch : MonoBehaviour
{
    //variables
    public GameObject carBody;
    public float enginePitch = 0.75f;
    public float highEnginePitch = 1.25f;

    // Start is called before the first frame update
    void Start()
    {
        //set engine pitch
        carBody.GetComponentInChildren<AudioSource>().pitch = enginePitch;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if(carBody.GetComponentInChildren<AudioSource>().pitch <= highEnginePitch)
            {
                carBody.GetComponentInChildren<AudioSource>().pitch += 0.001f;
            }
        }
        else 
        {
            if (carBody.GetComponentInChildren<AudioSource>().pitch >= enginePitch)
            {
                carBody.GetComponentInChildren<AudioSource>().pitch -= 0.001f;
            }
                
        }
    }
}
