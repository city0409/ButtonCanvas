using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyButton : MonoBehaviour ,IPointerClickHandler,IPointerEnterHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        print("OnPointerClick");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("OnPointerEnter");
    }
}
