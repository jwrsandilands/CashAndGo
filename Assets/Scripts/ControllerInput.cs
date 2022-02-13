using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    //variables
    public Vector3 worldPosition;
    TerrainCollider ground;

    private void Start()
    {
        //get the ground
        ground = Terrain.activeTerrain.GetComponent<TerrainCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //check if paused or if game is over
        if (!PauseControl.pauseGame && !PauseControl.gameOver)
        {
            //send a ray to the ground.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitData;
            //if the ground is hit, update the cursor position
            if (ground.Raycast(ray, out hitData, 1000))
            {

                worldPosition = hitData.point;
            }

            //update the cursor position
            transform.position = worldPosition;
        }
    }
}
