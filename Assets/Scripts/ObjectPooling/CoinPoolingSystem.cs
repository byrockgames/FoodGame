using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace ObjectPooling
{
 public class CoinPoolingSystem : MonoBehaviour
 {
    public static CoinPoolingSystem instance;
    private Queue<GameObject> Coins = new Queue<GameObject>();

    [Header("Main Camera")]
    [SerializeField]private Camera Cam;

    [Header("Coin Spawn Object")]
    public GameObject CoinObject;

    [Header("Spawn Size")]
    public int CoinSize;
    
    [Header("SpawnPivot")]
    [SerializeField]private Transform SpawnPivot;
    [SerializeField]private Transform TargetPivot;
    private Vector3 TargetPosition;
    private void Awake() 
    {
      TargetPosition = TargetPivot.position;
    }
    private void Start() 
    {
        if(instance == null)
        {
          instance = this;
        }

        Cam = Camera.main;

        for (int i = 0; i < CoinSize; i++)
        {
          GameObject temp = Instantiate(CoinObject, SpawnPivot);
          temp.transform.position = new Vector3(SpawnPivot.position.x, SpawnPivot.position.y, SpawnPivot.position.z);
          temp.SetActive(false);
          Coins.Enqueue(temp);
        }
    }
    
    public void CoinCollectedController(int Size)
    {
      for (int i = 0; i < Size; i++)
      {
        GameObject temp = Coins.Dequeue();
        temp.SetActive(true);
        temp.transform.DOMove(TargetPosition, Random.Range(1f, 2f)).SetEase(Ease.OutBack).OnComplete(()=>
        {
            temp.SetActive(false);
            Coins.Enqueue(temp);
        });
      }
    }

 } 
}

