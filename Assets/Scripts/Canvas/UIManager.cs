using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
   public static UIManager instance;
   [Header("Drag To Start")]
   [SerializeField]private TMP_Text DragToStart;

   [Header("Finish Game Text - Button")]
   [SerializeField]private TMP_Text FinishGameText;
   [SerializeField]private Button FinishGameToHome;
   
   [Header("Chest Animation")]
   [SerializeField]private Transform Chest;
  
   [Header("UI Panels")]
   [SerializeField]private RectTransform NaviagtionPanel;
   [SerializeField]private RectTransform MainMenuPanel;
   [SerializeField] private RectTransform SettingsPanel;
   [SerializeField] private RectTransform ShopPanel;
   [SerializeField]private GameObject PausedPanel;

   [Header("UI Navigation Buttons")]
   [SerializeField]private Button HomeButton;
   [SerializeField] private Button SettingsButton;
   [SerializeField] private Button ShopButton; 

   [Header("UI Paused Buttons")]
   [SerializeField]private Button Pause;
   [SerializeField]private Button PlayPaused;
   [SerializeField]private Button HomePaused;
   private void Start() 
   {
     if(instance == null)
     {
       instance = this;
     }

     // Animation    
     DragToStartAnimation();
     ChestAnimation();
     FinishGameTextAnimation();

     // UI Panel Controller
     NaviagtionPanelController();
     MainMenuPanelController();

     // UI Audio 
     FindObjectOfType<AudioManager>().Stop("ButtonClick");

     // UI Navigation Panel Buttons
     HomeButton.onClick.AddListener(MainMenuPanelController);
     SettingsButton.onClick.AddListener(SettingsPanelController);
     ShopButton.onClick.AddListener(ShopPanelController);

     // UI Paused Panel Controller - Buttons
     PausedPanel.SetActive(false);
     Pause.onClick.AddListener(PausedActive);
     PlayPaused.onClick.AddListener(PausedPassive);
     HomePaused.onClick.AddListener(HomePausedController);

     // Finish
     FinishGameToHome.onClick.AddListener(FinishGameToHomeController);

   }

    #region Animations Controller

      #region Drag To Start Animation
      void DragToStartAnimation()
      {
        DragToStart.transform.DOScale(1.25f, 0.4f).SetLoops(1000, LoopType.Yoyo).SetEase(Ease.InOutSine);
      }
      #endregion

      #region Finish Game Text Animation
      void FinishGameTextAnimation()
      {
        FinishGameText.transform.DOScale(1.25f, 0.4f).SetLoops(1000, LoopType.Yoyo).SetEase(Ease.InOutSine);
      }
      #endregion
      
      #region Chest Button Animation
      public void ChestAnimation()
      {
        Chest.DOScale(1.15f, 0.4f).SetLoops(10000, LoopType.Yoyo).SetEase(Ease.InBounce);

      }
      #endregion

    #endregion

    #region UI Panel Controller   
    private void NaviagtionPanelController()
    {
      // Navigation Open
      NaviagtionPanel.DOAnchorPos(new Vector2(0, -1040), 0.01f);
    }
    private void MainMenuPanelController()
    {
      // Main Open
      FindObjectOfType<AudioManager>().Play("ButtonClick");
      MainMenuPanel.DOAnchorPos(Vector2.zero, 0.01f);
      HomeButton.transform.DOScale(1.25f, 0.1f);

      // Settings Closed
      SettingsPanel.DOAnchorPos(new Vector2(1107, 0), 0.1f);
      SettingsButton.transform.DOScale(1f, 0.1f);

      // Shop Closed
      ShopPanel.DOAnchorPos(new Vector2(-1107, 0), 0.1f);
      ShopButton.transform.DOScale(1f, 0.1f);
    }

    private void SettingsPanelController()
    {
      // Main Closed
      MainMenuPanel.DOAnchorPos(new Vector2(0, -2369), 0.1f);
      HomeButton.transform.DOScale(1f, 0.1f);

      // Shop Closed
      ShopPanel.DOAnchorPos(new Vector2(-1107,0), 0.1f);
      ShopButton.transform.DOScale(1f, 0.1f);

      // Settings Open
      FindObjectOfType<AudioManager>().Play("ButtonClick");
      SettingsPanel.DOAnchorPos(Vector2.zero, 0.1f);
      SettingsButton.transform.DOScale(1.25f, 0.1f);
    }

    private void ShopPanelController()
    {
      // Main Closed
      MainMenuPanel.DOAnchorPos(new Vector2(0, -2369), 0.1f);
      HomeButton.transform.DOScale(1f, 0.1f);

      // Settings Closed
      SettingsPanel.DOAnchorPos(new Vector2(1107, 0), 0.1f);
      SettingsButton.transform.DOScale(1f, 0.1f);

      // Shop Open
      FindObjectOfType<AudioManager>().Play("ButtonClick");
      ShopPanel.DOAnchorPos(Vector2.zero, 0.1f);
      ShopButton.transform.DOScale(1.25f, 0.1f);
    }

    public void GamePanelController()
    {
      // Navigation Cloesed
      NaviagtionPanel.DOAnchorPos(new Vector2(0, -1320), 0.1f);

      // Main Closed
      MainMenuPanel.DOAnchorPos(new Vector2(0, -2369), 0.1f); 

      // Settings Closed
      SettingsPanel.DOAnchorPos(new Vector2(1107, 0), 0.1f); 
       
      // Shop Closed
      ShopPanel.DOAnchorPos(new Vector2(-1107, 0), 0.1f);   
    }

    private void FinishGameToHomeController()
    {
       SceneManager.LoadScene("GameScene");
    }
    #endregion

    #region UI Paused Panel Controller
    private void PausedActive()
    {
      PausedPanel.SetActive(true);
      Time.timeScale = 0;
      Timer.TimerController.instance.PauseActive();
    }
    private void PausedPassive()
    {
      PausedPanel.SetActive(false);
      Time.timeScale = 1;
      Timer.TimerController.instance.PausePassive();
    }
    private void HomePausedController()
    {
      SceneManager.LoadScene("GameScene");
      Time.timeScale = 1;
    }
    #endregion

}
