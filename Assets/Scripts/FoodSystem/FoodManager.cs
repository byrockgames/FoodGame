using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Food
{
 public class FoodManager : MonoBehaviour
 {
    public static FoodManager instance;

    [Header("Canvas Food Objects")]
    [SerializeField]private GameObject[] Foods;

    [Header("Food VFX")]
    public GameObject FoodCookedVFX;

    //Level 1 => Food 1 - 2
    [HideInInspector]public bool Food1, Food2, Level1;
    [HideInInspector]public int Salad, Tomato, Coconut, Lemon, Straw;

    //Level 2 => Food 3 - 4
    [HideInInspector]public bool Food3, Food4, Level2;
    [HideInInspector]public int Waffle, Chery, Grape, Steak, Salad2, Egg;

    //Level 3 => Food 5 - 6
    [HideInInspector] public bool Food5, Food6, Level3;
    [HideInInspector] public int Apple , Lemon2, Straw2, Pumpkin, Pie, Acorn;

    //Level 4 => Food 7 - 8
    [HideInInspector] public bool Food7, Food8, Level4;
    [HideInInspector] public int Apple2, Kiwi, Straw3, Banana, Carrot, Orange;

    //Level 5 => Food 9 - 10
    [HideInInspector]public bool Food9, Food10, Level5;
    [HideInInspector]public int Fish, Lemon3, Bread, Egg2, Salad3;

    //Level 6 => Food 11 - 12
    [HideInInspector]public bool Food11, Food12, Level6;
    [HideInInspector]public int Kebap, Tomato2, Pepper, Mushroom, Chicken, Pineapple;

    //Level 7 => Food 13 - 14
    [HideInInspector]public bool Food13, Food14, Level7;
    [HideInInspector]public int Apple3, Orange2, Straw4, Tomato3, Pea, Sweetpepper;

    //Level 8 => Food 15 - 16
    [HideInInspector]public bool Food15, Food16, Level8;
    [HideInInspector]public int Kofte, Lemon4, Salad4, Chicken2, Potato;

    //Level 9 => Food 17 - 18
    [HideInInspector]public bool Food17, Food18, Level9;
    [HideInInspector]public int HamburgerBread, Kofte2, Salad5, Avocado, Bread2;

    //Level 10 => Food 19 - 20
    [HideInInspector]public bool Food19, Food20, Level10;
    [HideInInspector]public int Pasta, Tomato4, Mushroom2, Carrot2, Pea2;

    //Level 11 => Food 21 - 22
    [HideInInspector]public bool Food21, Food22, Level11;
    [HideInInspector]public int Cips, Tomato5, Onion, Sushi, Salad6;

    //Level 11 => Food 21 - 22
    [HideInInspector]public bool Food23, Food24, Level12;
    [HideInInspector]public int PotatoFull, Pea3, Carrot3 , Crab, Salad7, Lemon5;
    private void Start() 
    {
     if(instance == null)
     {
       instance = this;
     }

     foreach (GameObject food in Foods)
     {
        food.SetActive(false);
     }

      // Food VFX 
      FoodCookedVFX.SetActive(false);  
    }
    private void Update() 
   {
     FoodsPanelController();
   }

   #region Level System To Foods
   public void FoodsPanelController()
   {
      #region Food 1 - 2
      if(Data.DataSystem.instance.LevelCount == 0)
      {
        Foods[0].SetActive(true);
        Food1 = true;

        if(Salad == 3 && Tomato == 2)
        {  
           Foods[0].SetActive(false);
           Food1 = false;
           Level1 = true;

           Foods[1].SetActive(true);
           Food2 = true;
        }
        if(Coconut == 3 && Lemon == 2 && Straw == 1)
        {
          Food2 = false;
          Level1 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
        Food1 = false;
        Food2 = false;
      }
      #endregion

      #region Food 3 - 4
      if(Data.DataSystem.instance.LevelCount == 1)
      {
        Foods[2].SetActive(true);
        Food3 = true;

        if (Waffle == 3 && Chery == 2 && Grape == 5)
        {
          Foods[2].SetActive(false);
          Food3 = false;
          Level2 = true;

          Foods[3].SetActive(true);
          Food4 = true;
        }
        if(Steak == 1 && Salad2 == 3 && Egg == 2)
        {
          Food4 = false;
          Level2 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
        Food3 = false;
        Food4 = false;
      }
      #endregion
      
      #region Food 5 - 6
      if(Data.DataSystem.instance.LevelCount == 2)
      {
        Foods[4].SetActive(true);
        Food5 = true;

        if(Apple == 5 && Straw2 == 1 && Lemon2 == 2)
        {
          Foods[4].SetActive(false);
          Food5 = false;
          Level3 = true;

          Foods[5].SetActive(true);
          Food6 = true;
        }
        if(Pumpkin == 2 && Pie == 1 && Acorn == 5)
        {
          Food6 = false;
          Level3 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
        Food5 = false;
        Food6 = false;
      }
      #endregion

      #region  Food 7 - 8

      if(Data.DataSystem.instance.LevelCount == 3)
      { 
        Foods[6].SetActive(true);
        Food7 = true;

        if(Apple2 == 5 && Kiwi == 5 && Straw3 == 1)
        {
          Foods[6].SetActive(false);
          Food7 = false;
          Level4 = true;

          Foods[7].SetActive(true);
          Food8 = true;
        }
        if(Banana == 5 && Carrot == 5 && Orange == 5)
        {
          Food8 = false;
          Level4 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      { 
        Food7 = false;
        Food8 = false;
      }
      #endregion

      #region  Food 9 - 10
      if(Data.DataSystem.instance.LevelCount == 4)
      {
        Foods[8].SetActive(true);
        Food9 = true;

        if(Fish == 1 && Lemon3 == 2)
        {
          Foods[8].SetActive(false);
          Food9 = false;
          Level5 = true;

          Foods[9].SetActive(true);
          Food10 = true;
        }
        if(Bread == 1 && Egg2 == 2 && Salad3 == 3)
        {
          Food10 = false;
          Level5 = false;
          GameManager.instance.VictoryPanelActive();
        }

      }
      else
      {
         Food9 = false;
         Food10 = false;
      }
      #endregion

      #region Food 11 - 12
      if(Data.DataSystem.instance.LevelCount == 5)
      {
        Foods[10].SetActive(true);
        Food11 = true;

        if(Kebap == 3 && Tomato2 == 2 && Pepper == 3)
        {
          Foods[10].SetActive(false);
          Food11 = false;
          Level6 = true;

          Foods[11].SetActive(true);
          Food12 = true;
        }
        if(Mushroom == 5 && Chicken == 5 && Pineapple == 3)
        {
          Food12 = false;
          Level6 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
         Food11 = false;
         Food12 = false;
      }
      #endregion
      
      #region Food 13 - 14
      if(Data.DataSystem.instance.LevelCount == 6)
      {
        Foods[12].SetActive(true);
        Food13 = true;

        if(Apple3 == 5 && Orange2 == 5 && Straw4 == 1)
        {
          Foods[12].SetActive(false);
          Food13 = false;
          Level7 = true;

          Foods[13].SetActive(true);
          Food14 = true;
        }
        if(Tomato3 == 2 && Pea == 4 && Sweetpepper == 5)
        {
          Food14 = false;
          Level7 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
         Food13 = false;
         Food14 = false;
      }
      #endregion

      #region Food 15 - 16
      if(Data.DataSystem.instance.LevelCount == 7)
      {
        Foods[14].SetActive(true);
        Food15 = true;

        if(Kofte == 4 && Lemon4 == 2 && Salad4 == 3)
        {
          Foods[14].SetActive(false);
          Food15 = false;
          Level8 = true;

          Foods[15].SetActive(true);
          Food16 = true;
        }
        if(Chicken2 == 5 && Potato == 3)
        {
          Food16 = false;
          Level8 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
        Food15 = false;
        Food16 = false;
      }
      #endregion

      #region  Food 17 - 18
      if(Data.DataSystem.instance.LevelCount == 8)
      {
        Foods[16].SetActive(true);
        Food17 = true;

        if(HamburgerBread == 2 && Kofte2 == 4 && Salad5 == 3)
        {
          Foods[16].SetActive(false);
          Food17 = false;
          Level9 = true;

          Foods[17].SetActive(true);
          Food18 = true;
        }
        if(Avocado == 3 && Bread2 == 2)
        {
          Food18 = false;
          Level9 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
        Food17 = false;
        Food18 = false;
      }
      #endregion
      
      #region Food 19 - 20
      if(Data.DataSystem.instance.LevelCount == 9)
      {
        Foods[18].SetActive(true);
        Food19 = true;

        if(Pasta == 6 && Tomato4 == 2)
        {
          Foods[18].SetActive(false);
          Food19 = false;
          Level10 = true;

          Foods[19].SetActive(true);
          Food20 = true;
        }
        if(Mushroom2 == 5 && Carrot2 == 5 && Pea2 == 4)
        {
          Food20 = false;
          Level10 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
        Food19 = false;
        Food20 = false;
      }
      #endregion

      #region Food 21 - 22
      if(Data.DataSystem.instance.LevelCount == 10)
      {
        Foods[20].SetActive(true);
        Food21 = true;

        if(Cips == 5 && Tomato5 == 2 && Onion == 4)
        {
          Foods[20].SetActive(false);
          Food21 = false;
          Level11 = true;

          Foods[21].SetActive(true);
          Food22 = true;
        }
        if(Sushi == 6 && Salad6 == 3)
        {
          Food22 = false;
          Level11 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
        Food21 = false;
        Food22 = false;
      }
      #endregion

      #region Food 23 - 24
      if(Data.DataSystem.instance.LevelCount == 11)
      {
        Foods[22].SetActive(true);
        Food23 = true;

        if(PotatoFull == 5 && Pea3 == 4 && Carrot3 == 5)
        {
          Foods[22].SetActive(false);
          Food23 = false;
          Level12 = true;

          Foods[23].SetActive(true);
          Food24 = true;
        }
        if(Crab == 1 && Salad7 == 3 && Lemon5 == 2)
        {
          Food24 = false;
          Level12 = false;
          GameManager.instance.VictoryPanelActive();
        }
      }
      else
      {
        Food23 = false;
        Food24 = false;
      }
      #endregion
      
      #region Finish
      if(Data.DataSystem.instance.LevelCount == 12)
      {
         GameManager.instance.FinishGameController();
      }
      #endregion

    }
    #endregion
  
  public void FoodFinishController()
  {
    Food.FoodManager.instance.FoodCookedVFX.SetActive(true);
    FindObjectOfType<AudioManager>().Play("CoinCollected");
    ObjectPooling.CoinPoolingSystem.instance.CoinCollectedController(15);

    Data.DataSystem.instance.CoinCount += 15;
    PlayerPrefs.SetInt("CoinData", Data.DataSystem.instance.CoinCount);
    Data.DataSystem.instance.CoinConutTextController();
  }

 } 
}

