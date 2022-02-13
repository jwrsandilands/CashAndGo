using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIResumeButton : MonoBehaviour , IPointerClickHandler
{
    public bool clicked = false;

    //when clicked set clicked to true
    public void OnPointerClick(PointerEventData eventData)
    {
        clicked = true;
    }
}
