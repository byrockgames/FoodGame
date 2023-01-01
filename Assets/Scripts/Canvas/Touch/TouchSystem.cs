using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchSystem : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData pointerEventData)
    {
       UIManager.instance.GamePanelController();
       Timer.TimerController.instance.Beging(Timer.TimerController.instance.Duration);
    }
}
