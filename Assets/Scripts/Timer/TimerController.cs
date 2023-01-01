using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Timer
{
 public class TimerController : MonoBehaviour
 {
    public static TimerController instance;

    [Header("Text")]
    [SerializeField]private TMP_Text TimerText;

    [Header("Pause")]
    public bool Pause = false;

    [Header("Time")]
    public int Duration;
    private int RemainingDuration; 
    private void Start() 
    {
      Pause = false;

      if(instance == null)
      {
          instance = this;
      }
    }
    public void Beging(int Second)
    {
       RemainingDuration = Second;
       StartCoroutine(UpdateTimer());
    }

    IEnumerator UpdateTimer()
    {
      while(RemainingDuration >= 0)
      { 
        if(Pause == false)
        {
          TimerText.text = $"{RemainingDuration / 60:00} : {RemainingDuration % 60:00}";
          RemainingDuration--;
          yield return new WaitForSeconds(1f);
        }             
         yield return null;     
      }
      OnEnd();
    }

    public void PauseActive()
    {
      Pause = true;
    }

    public void PausePassive()
    {
      Pause = false;
    }

    public void ExtraTime()
    {
        RemainingDuration += 30;                 
        Pause = false;
        StartCoroutine(ExtraTimeControl());
    }
    IEnumerator ExtraTimeControl()
    {
      while(RemainingDuration >= 0)
      {
        if(Pause == false)
        {
          TimerText.text = $"{RemainingDuration / 60:00} : {RemainingDuration % 60:00}";
          RemainingDuration --;
          yield return new WaitForSeconds(1f);
        }
        yield return null;
      }      
      OnEnd();
    }

    private void OnEnd()
    {             
      GameManager.instance.GameOverPanelActive(); 
    }
 } 
}

