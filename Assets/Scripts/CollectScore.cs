using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScore : MonoBehaviour
{
    //variables
    public int coinScore;
    public int playerScore;
    public AudioClip coinAudio, coneAudio;
    public GameObject cameraMic;
    
    //when this object collides with other objects
    private void OnTriggerEnter(Collider other)
    {
        //is it coin or cone?
        if(other.tag == "Coin")
        {
            //add the score
            playerScore += coinScore;
            //destroy and play sound
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(coinAudio, cameraMic.transform.position);
        }
        if(other.tag == "Cone")
        {
            //subtract the score, but no negative numbers!
            if(playerScore >= 30)
            {
                playerScore -= coinScore * 3;
            }
            else
            {
                playerScore -= playerScore;
            }

            //Destroy and play sound
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(coneAudio, cameraMic.transform.position);
        }
    }
}
