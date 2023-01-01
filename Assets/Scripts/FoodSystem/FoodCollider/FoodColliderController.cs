using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Food
{
 public class FoodColliderController : MonoBehaviour
 {
    public static FoodColliderController instance;
    private void Start() 
    {
        if(instance == null)
        {
          instance = this;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
      #region  Food 1 - 2 
        if(Food.FoodManager.instance.Food1 == true)
        {
          if(other.gameObject.CompareTag("Salad"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Salad ++;
          }
          else if(other.gameObject.CompareTag("Tomato"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Tomato ++;
          }
          else
          {
            Food.FoodController.instance.ObjectLaunching();
          }
        }
        
        if(Food.FoodManager.instance.Food2 == true)
        {
          if(other.gameObject.CompareTag("Coconut"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Coconut++; 
          }
          else if (other.gameObject.CompareTag("Lemon"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Lemon++;
          }
          else if (other.gameObject.CompareTag("Straw"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Straw++;
          }
          else
          {
           Food.FoodController.instance.ObjectLaunching();
          }                 
        }            
        #endregion

      #region  Food 3 - 4
        if(Food.FoodManager.instance.Food3 == true)
        {
          if(other.gameObject.CompareTag("Waffle"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Waffle++;
          }
          else if(other.gameObject.CompareTag("Chery"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Chery++;
          }
          else if(other.gameObject.CompareTag("Grape"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Grape++;
          }
          else
          {
            Food.FoodController.instance.ObjectLaunching();
          }
        }

        if(Food.FoodManager.instance.Food4 == true)
        {
          if (other.gameObject.CompareTag("Steak"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Steak++;
          }
          else if (other.gameObject.CompareTag("Salad"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Salad2++;
          }
          else if (other.gameObject.CompareTag("Egg"))
          {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Egg++;
          }
          else
          {
            Food.FoodController.instance.ObjectLaunching();
          }
        }
        #endregion
          
      #region  Food 5 - 6
         if(Food.FoodManager.instance.Food5 == true)
         {
           if(other.gameObject.CompareTag("Apple"))
           {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Apple++;
           }          
           else if (other.gameObject.CompareTag("Lemon"))
           {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Lemon2++;
           }
           else if (other.gameObject.CompareTag("Straw"))
           {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Straw2++;
           }
           else
           {
            Food.FoodController.instance.ObjectLaunching();
           }
         }

         if(Food.FoodManager.instance.Food6 == true)
         {
            if (other.gameObject.CompareTag("Pumpkin"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Pumpkin++;
            }
            else if (other.gameObject.CompareTag("Pie"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Pie++;
            }
            else if (other.gameObject.CompareTag("Acorn"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Acorn++;
            }
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }
        #endregion 

      #region  Food 7 - 8
         if(Food.FoodManager.instance.Food7 == true)
         {
           if(other.gameObject.CompareTag("Apple"))
           {
            other.gameObject.layer = 0;
            Food.FoodManager.instance.Apple2++;
           }          
           else if (other.gameObject.CompareTag("Kiwi"))
           {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Kiwi++;
           }
           else if (other.gameObject.CompareTag("Straw"))
           {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Straw3++;
           }
           else
           {
            Food.FoodController.instance.ObjectLaunching();
           }
         }

         if(Food.FoodManager.instance.Food8 == true)
         {
            if (other.gameObject.CompareTag("Banana"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Banana++;
            }
            else if (other.gameObject.CompareTag("Carrot"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Carrot++;
            }
            else if (other.gameObject.CompareTag("Orange"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Orange++;
            }
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }
         #endregion
 
      #region Food 9 -10
         if(Food.FoodManager.instance.Food9 == true)
         {
            if (other.gameObject.CompareTag("Fish"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Fish++;
            }
            else if (other.gameObject.CompareTag("Lemon"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Lemon3++;
            }          
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }

         if(Food.FoodManager.instance.Food10 == true)
         {
            if (other.gameObject.CompareTag("Bread"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Bread++;
            }
            else if(other.gameObject.CompareTag("Egg"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Egg2++;
            }
            else if(other.gameObject.CompareTag("Salad"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Salad3++;
            }
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }
         #endregion

      #region Food 11 -12
         if(Food.FoodManager.instance.Food11 == true)
         {
            if (other.gameObject.CompareTag("Kebap"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Kebap++;
            }
            else if (other.gameObject.CompareTag("Tomato"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Tomato2++;
            }
            else if(other.gameObject.CompareTag("Pepper"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Pepper++;
            }       
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }

         if(Food.FoodManager.instance.Food12 == true)
         {
            if (other.gameObject.CompareTag("Mushroom"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Mushroom++;
            }
            else if(other.gameObject.CompareTag("Chicken"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Chicken++;
            }
            else if(other.gameObject.CompareTag("Pineapple"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Pineapple++;
            }
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }
         #endregion
     
      #region  Food 13 - 14
         if(Food.FoodManager.instance.Food13 == true)
         {
            if (other.gameObject.CompareTag("Apple"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Apple3++;
            }
            else if (other.gameObject.CompareTag("Orange"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Orange2++;
            }
            else if(other.gameObject.CompareTag("Straw"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Straw4++;
            }       
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }

         if(Food.FoodManager.instance.Food14 == true)
         {
            if (other.gameObject.CompareTag("Tomato"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Tomato3++;
            }
            else if(other.gameObject.CompareTag("Pea"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Pea++;
            }
            else if(other.gameObject.CompareTag("Sweetpepper"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Sweetpepper++;
            }
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }
      #endregion

      #region Food 15 - 16
         if(Food.FoodManager.instance.Food15 == true)
         {
            if (other.gameObject.CompareTag("Kofte"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Kofte++;
            }
            else if (other.gameObject.CompareTag("Lemon"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Lemon4++;
            }
            else if(other.gameObject.CompareTag("Salad"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Salad4++;
            }       
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }

         if(Food.FoodManager.instance.Food16 == true)
         {
            if (other.gameObject.CompareTag("Chicken"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Chicken2++;
            }
            else if(other.gameObject.CompareTag("Potato"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Potato++;
            }
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }
      #endregion
      
      #region  Food 17 - 18
        if(Food.FoodManager.instance.Food17 == true)
         {
            if (other.gameObject.CompareTag("HamburgerBread"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.HamburgerBread++;
            }
            else if (other.gameObject.CompareTag("Kofte"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Kofte2++;
            }
            else if(other.gameObject.CompareTag("Salad"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Salad5++;
            }       
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }

         if(Food.FoodManager.instance.Food18 == true)
         {
            if (other.gameObject.CompareTag("Avocado"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Avocado++;
            }
            else if(other.gameObject.CompareTag("Bread"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Bread2++;
            }
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }
      #endregion

      #region Food 19 - 20
         if(Food.FoodManager.instance.Food19 == true)
         {
            if (other.gameObject.CompareTag("Pasta"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Pasta++;
            }
            else if (other.gameObject.CompareTag("Tomato"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Tomato4++;
            }                 
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }

         if(Food.FoodManager.instance.Food20 == true)
         {
            if (other.gameObject.CompareTag("Mushroom"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Mushroom2++;
            }
            else if(other.gameObject.CompareTag("Carrot"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Carrot2++;
            }
            else if(other.gameObject.CompareTag("Pea"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Pea2++;
            }
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }
      #endregion

      #region Food 21 - 22
         if(Food.FoodManager.instance.Food21 == true)
         {
            if (other.gameObject.CompareTag("Cips"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Cips++;
            }
            else if (other.gameObject.CompareTag("Tomato"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Tomato5++;
            } 
            else if (other.gameObject.CompareTag("Onion"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Onion++;
            }                
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }

         if(Food.FoodManager.instance.Food22 == true)
         {
            if (other.gameObject.CompareTag("Sushi"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Sushi++;
            }
            else if(other.gameObject.CompareTag("Salad"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Salad6++;
            }         
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }
      #endregion
      
      #region Food 23 - 24
         if(Food.FoodManager.instance.Food23 == true)
         {
            if (other.gameObject.CompareTag("PotatoFull"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.PotatoFull++;
            }
            else if (other.gameObject.CompareTag("Pea"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Pea3++;
            } 
            else if (other.gameObject.CompareTag("Carrot"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Carrot3++;
            }                
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }

         if(Food.FoodManager.instance.Food24 == true)
         {
            if (other.gameObject.CompareTag("Crab"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Crab++;
            }
            else if(other.gameObject.CompareTag("Salad"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Salad7++;
            }         
            else if(other.gameObject.CompareTag("Lemon"))
            {
              other.gameObject.layer = 0;
              Food.FoodManager.instance.Lemon5++;
            }
            else
            {
              Food.FoodController.instance.ObjectLaunching();
            }
         }

      #endregion

    }

    private void OnTriggerStay(Collider other) 
    {
        if(Food.FoodManager.instance.Level1 == true) 
        {
          if(other.gameObject.CompareTag("Salad") || other.gameObject.CompareTag("Tomato"))
          {            
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }          
        }

        if(Food.FoodManager.instance.Level2 == true)
        {
          if (other.gameObject.CompareTag("Waffle") || other.gameObject.CompareTag("Chery")|| other.gameObject.CompareTag("Grape"))
          {           
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();             
          }
        }

        if (Food.FoodManager.instance.Level3 == true)
        {
          if (other.gameObject.CompareTag("Apple") || other.gameObject.CompareTag("Lemon") || other.gameObject.CompareTag("Straw"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        }  

        if (Food.FoodManager.instance.Level4 == true)
        {
          if (other.gameObject.CompareTag("Apple") || other.gameObject.CompareTag("Kiwi") || other.gameObject.CompareTag("Straw"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        } 

        if(Food.FoodManager.instance.Level5 == true)
        {
          if (other.gameObject.CompareTag("Fish") || other.gameObject.CompareTag("Lemon"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        } 

        if(Food.FoodManager.instance.Level6 == true)
        {
          if (other.gameObject.CompareTag("Kebap") || other.gameObject.CompareTag("Tomato") || other.gameObject.CompareTag("Pepper"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        }

        if(Food.FoodManager.instance.Level7 == true)
        {
          if (other.gameObject.CompareTag("Apple") || other.gameObject.CompareTag("Orange") || other.gameObject.CompareTag("Straw"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        } 

        if(Food.FoodManager.instance.Level8 == true)
        {
          if (other.gameObject.CompareTag("Kofte") || other.gameObject.CompareTag("Lemon") || other.gameObject.CompareTag("Salad"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        } 
        
        if(Food.FoodManager.instance.Level9 == true)
        {
          if (other.gameObject.CompareTag("HamburgerBread") || other.gameObject.CompareTag("Kofte") || other.gameObject.CompareTag("Salad"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        } 

        if(Food.FoodManager.instance.Level10 == true)
        {
          if (other.gameObject.CompareTag("Pasta") || other.gameObject.CompareTag("Tomato"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        }

        if(Food.FoodManager.instance.Level11 == true)
        {
          if (other.gameObject.CompareTag("Cips") || other.gameObject.CompareTag("Tomato") || other.gameObject.CompareTag("Onion"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        }

        if(Food.FoodManager.instance.Level12 == true)
        {
          if (other.gameObject.CompareTag("PotatoFull") || other.gameObject.CompareTag("Pea") || other.gameObject.CompareTag("Carrot"))
          {
            other.gameObject.SetActive(false);
            Food.FoodManager.instance.FoodFinishController();
          }
        }
              
    }

  }  
}

