using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BackToMenuButton : MonoBehaviour , IPointerClickHandler
{
    public bool clicked = false;

    //On click start game
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        clicked = true;
    }
}
