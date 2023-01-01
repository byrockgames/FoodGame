using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance; 

    [Header("Victory Panel Controller")]
    [SerializeField]private GameObject VictoryPanel;
    [SerializeField]private Button NextLevel;
    [SerializeField]private Button VİctoryToHome;

    [Header("Game Over Controller")]
    [SerializeField]private GameObject GameOverPanel;
    [SerializeField]private Button ReturnGame;
    [SerializeField]private Button ExtraTime;

    [Header("Settings Panel Controller")]
    [SerializeField]private Toggle SoundEffects;
    [SerializeField]private Button PrivacyPolicy;
    [SerializeField]private Button Contact;

    [Header("User Settings")]
    [SerializeField]private Button Save;
    [SerializeField]private Button Reset;
    public TMP_InputField Nickname;
    public TMP_Text NicknameText;

    [Header("ChestSystem")]   
    [SerializeField]private GameObject ChestPanel;
    [SerializeField]private Button Chest;
    [SerializeField]private Button FreeCoin;
    [SerializeField]private TMP_Text ChestLevelText;
    [SerializeField]private Image ChsetBar;
    private int CurrentChestLevel = 3;

    [Header("Finish Game")]
    [SerializeField]private GameObject FinishGamePanel;

    void Start()
    {
        if(instance == null)
        {
          instance = this;
        }

        // Time
        Time.timeScale = 1;

        // Victory Panel Controller  
        VictoryPanel.SetActive(false); 
        NextLevel.onClick.AddListener(NextLevelController);
        VİctoryToHome.onClick.AddListener(VictoryToHomeController); 

        // GameOver Panel Controller
        GameOverPanel.SetActive(false);  
        ExtraTime.onClick.AddListener(ExtraTimeController);
        ReturnGame.onClick.AddListener(ReturnGameController);

        // Settings Panel Controller
        PrivacyPolicy.onClick.AddListener(PrivacyPolicyController);
        Contact.onClick.AddListener(ContactController);

        // Home Panel Controller
        Save.onClick.AddListener(InputFieldController);
        Reset.onClick.AddListener(UserDataReset);
        NicknameText.text = "Hi," + "" + PlayerPrefs.GetString("NicknameData");

        // Chest Panel Controller
        ChestLevelText.text = PlayerPrefs.GetInt("ChestData").ToString();
        ChestPanel.SetActive(false);
        Chest.onClick.AddListener(ChestPanelActive);
        FreeCoin.onClick.AddListener(FreeCoinController);

        // Finish Game Controller
        FinishGamePanel.SetActive(false);
       
    }
    private void FixedUpdate() 
    {
      // Settings Sound Control
      ToogleController();

      // Chest Control
      ChestController();
      
     
    }

    #region Settings Panel 
    private void ToogleController()
    {
        if(SoundEffects.isOn == true)
        {
          FindObjectOfType<AudioManager>().SoundEffectsPassive("ButtonClick");
          FindObjectOfType<AudioManager>().SoundEffectsPassive("CoinCollected");
          FindObjectOfType<AudioManager>().SoundEffectsPassive("Victory");
          FindObjectOfType<AudioManager>().SoundEffectsPassive("GameOver");
        }

        if(SoundEffects.isOn == false)
        {
          FindObjectOfType<AudioManager>().SoundEffectsActive("ButtonClick");
          FindObjectOfType<AudioManager>().SoundEffectsActive("CoinCollected");
          FindObjectOfType<AudioManager>().SoundEffectsActive("Victory");
          FindObjectOfType<AudioManager>().SoundEffectsActive("GameOver");
        }
    }
    private void PrivacyPolicyController()
    {
      string PrivacyPolicyUrl = "https://www.connectinno.com/privacy-policy";
      Application.OpenURL(PrivacyPolicyUrl);
    }
    private void ContactController()
    {
      string ContactUrl = "https://www.connectinno.com/contact";
      Application.OpenURL(ContactUrl);
    }
    private void InputFieldController()
    {
      Data.DataSystem.instance.NicknameData = Nickname.text;
      NicknameText.text = "Hi," + "" + Nickname.text;
      PlayerPrefs.SetString("NicknameData", Data.DataSystem.instance.NicknameData);
    }
    private void UserDataReset()
    {
      PlayerPrefs.DeleteKey("NicknameData");
    }
    #endregion

    #region Chest Controller
    public void ChestController()
    {
      float fillAmount = (float)Data.DataSystem.instance.ChestCount / (float)CurrentChestLevel;
      ChsetBar.fillAmount = fillAmount;

      if(Data.DataSystem.instance.ChestCount < 3)
      {
        Chest.interactable = false;
      }
      else if(Data.DataSystem.instance.ChestCount == 3)
      {
        Chest.interactable = true;
      }
    }
    private void ChestPanelActive()
    {
      ChestPanel.SetActive(true);
    }
    private void FreeCoinController()
    {
       Data.DataSystem.instance.CoinCount += 15;     
       PlayerPrefs.SetInt("CoinData", Data.DataSystem.instance.CoinCount);
       Data.DataSystem.instance.CoinConutTextController();
       ChestPanel.SetActive(false); 
       
       Data.DataSystem.instance.ChestCount = 0;      
       PlayerPrefs.SetInt("ChestData", Data.DataSystem.instance.ChestCount);
       ChestLevelText.text = PlayerPrefs.GetInt("ChestData").ToString();
    }
    #endregion

    #region Victory Controller
    public void VictoryPanelActive()
    {          
      VictoryPanel.SetActive(true);
      Timer.TimerController.instance.PauseActive();      
      Time.timeScale = 0;       
    }
    public void NextLevelController()
    {        
      SceneManager.LoadScene("GameScene");
      Time.timeScale = 1;

      Food.FoodManager.instance.FoodFinishController();

      Data.DataSystem.instance.LevelCount += 1;
      PlayerPrefs.SetInt("LevelData",Data.DataSystem.instance.LevelCount);
      Data.DataSystem.instance.LevelCountTextController();

      Data.DataSystem.instance.ChestCount += 1;
      PlayerPrefs.SetInt("ChestData", Data.DataSystem.instance.ChestCount);
      ChestLevelText.text = PlayerPrefs.GetInt("ChestData").ToString();
    }
    public void VictoryToHomeController()
    {     
      SceneManager.LoadScene("GameScene");
      Time.timeScale = 1;

      Food.FoodManager.instance.FoodFinishController();
      
      Data.DataSystem.instance.LevelCount += 1;
      PlayerPrefs.SetInt("LevelData", Data.DataSystem.instance.LevelCount);
      Data.DataSystem.instance.LevelCountTextController();

      Data.DataSystem.instance.ChestCount += 1;
      PlayerPrefs.SetInt("ChestData", Data.DataSystem.instance.ChestCount);
      ChestLevelText.text = PlayerPrefs.GetInt("ChestData").ToString();
    }
    #endregion

    #region  Game Over Controller
    
    public void GameOverPanelActive()
    {
      FindObjectOfType<AudioManager>().Play("GameOver");
      GameOverPanel.SetActive(true);
      Time.timeScale = 0;
      if(Data.DataSystem.instance.CoinCount < 5)
      {
        ExtraTime.interactable = false;
      }
    }

    public void ReturnGameController()
    {
      SceneManager.LoadScene("GameScene");
      Time.timeScale = 1;
    }

    public void ExtraTimeController()
    {
      if(Data.DataSystem.instance.CoinCount >= 5)
      {
        ExtraTime.interactable = true;
        GameOverPanel.SetActive(false);
        Time.timeScale = 1;
        Timer.TimerController.instance.ExtraTime();

        Data.DataSystem.instance.CoinCount -= 5;
        PlayerPrefs.SetInt("CoinData", Data.DataSystem.instance.CoinCount); 
        Data.DataSystem.instance.CoinConutTextController();     
      }            
    }
    #endregion

    #region Finish Game Controller
    public void FinishGameController()
    {
        FinishGamePanel.SetActive(true);
    }
    #endregion

}
