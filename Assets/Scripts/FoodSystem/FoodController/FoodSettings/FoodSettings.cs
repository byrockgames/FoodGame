using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Food
{
 [CreateAssetMenu(fileName = "FoodSettings", menuName = "FoodGame/FoodController/FoodSettings")]
 public class FoodSettings : ScriptableObject
 {
   [Header("Touch Speed Settings")]   
   [Range(1, 1000)] public float DragSpeed;   
   [Range(10, 250)] public float ObjectRotateSpeed;

   [Header("Height")]
   [Range(0.5f, 20)] public float ObjectHeight;

   [Header("Food Layer")]
   public LayerMask layer;
 } 
}
