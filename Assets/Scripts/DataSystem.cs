using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Data
{
 public class DataSystem : MonoBehaviour
 { 
   public static DataSystem instance;
   
   // Nickname Data
   [HideInInspector] public string NicknameData;  

   [Header("Level Count - Data")]
   public int LevelCount;
   [SerializeField]private TMP_Text LevelText;
   [SerializeField]private TMP_Text GameLevelText;

   [Header("Coin Count - Data")]
   public int CoinCount;
  [SerializeField] private TMP_Text CoinText;
   [SerializeField]private TMP_Text GameCoinText;

   [Header("Chest Count - Data")]
   public int ChestCount;              
   private void Start() 
   {
      if(instance == null)
      {
        instance = this;
      }

      if(CoinCount < 0)
      {
         CoinCount = 0;
         PlayerPrefs.SetInt("CoinData", CoinCount);
      }

      // Data Get
      NicknameData = PlayerPrefs.GetString("NicknameData");
      LevelCount = PlayerPrefs.GetInt("LevelData");
      CoinCount = PlayerPrefs.GetInt("CoinData");
      ChestCount = PlayerPrefs.GetInt("ChestData"); 
      
      // Text Data Get
      LevelText.text = PlayerPrefs.GetInt("LevelData").ToString();
      GameLevelText.text = PlayerPrefs.GetInt("LevelData").ToString();

      CoinText.text = PlayerPrefs.GetInt("CoinData").ToString();  
      GameCoinText.text = PlayerPrefs.GetInt("CoinData").ToString(); 
   }

   public void CoinConutTextController()
   {
      CoinText.text = CoinCount.ToString();
      GameCoinText.text = CoinCount.ToString();
   }

   public void LevelCountTextController()
   {
     LevelText.text = LevelCount.ToString();
     GameLevelText.text = LevelCount.ToString();
   }

 }
}
