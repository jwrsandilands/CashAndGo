using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameQuitButton : MonoBehaviour, IPointerClickHandler
{
    //On click close game
    public void OnPointerClick(PointerEventData eventData)
    {
        Application.Quit();
    }
}
