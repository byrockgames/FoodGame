using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ObjectPooling
{
 public class ObjectPoolingSystem : MonoBehaviour
 {
    public static ObjectPoolingSystem instance;
    
    [Serializable]
    public struct Pool
    {
       public List<GameObject> PooledObject;

       [Header("Spawn Object")]
       public GameObject SpawnObejcts;

       [Header("Spawn Size")]
       public int ObjectSize;
    }

    [Header("Pool")]
    [SerializeField]private Pool[] pools = null;
    private List<GameObject> Foods = new List<GameObject>();

    [Header("SpawnPivot")]
    [SerializeField]private Transform SpawnPivot;

    private void Start() 
    {
      if(instance == null)
      {
         instance = this;
      }
      
      Invoke("RigidbodyStartControl", 1.5f);
    }

    private void Awake() 
    {
       for(int i = 0; i< pools.Length; i++)
       {
         pools[i].PooledObject = new List<GameObject>();

         for(int j = 0; j < pools[i].ObjectSize; j++)
         {
            GameObject temp = Instantiate(pools[i].SpawnObejcts, SpawnPivot);
            temp.transform.position = new Vector3(SpawnPivot.position.x, SpawnPivot.position.y, SpawnPivot.position.z);
            temp.gameObject.GetComponent<Rigidbody>().drag = 15;
            temp.SetActive(true);
            pools[i].PooledObject.Add(temp);
            Foods.Add(temp);         
         }
       } 
    }

   #region Rigidbody Variation
   public void RigidbodyStartControl()
    {
       foreach (GameObject foods in Foods)
       {
         foods.gameObject.GetComponent<Rigidbody>().drag = 4;
       }
    }
    #endregion
 } 
}

