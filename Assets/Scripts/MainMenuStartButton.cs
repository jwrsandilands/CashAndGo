using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuStartButton : MonoBehaviour, IPointerClickHandler
{
    //On click start game
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("CityMap", LoadSceneMode.Single);
    }
}
