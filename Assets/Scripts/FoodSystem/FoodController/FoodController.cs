using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Food
{
 public class FoodController : MonoBehaviour
 {
    public static FoodController instance;
    [Header("Food Settings")]
    [SerializeField]private Food.FoodSettings FoodSettings;
    private bool IsTouch = false;
    private bool RigidbodyControl = false;
    private GameObject SelectedObject = null;
    private Rigidbody SelectedRigid = null;
    private Vector3 Move; 
    private void Start() 
    {
      if(instance == null)
      {
        instance = this;
      }   
    }
    private void FixedUpdate() 
    { 
      #region Touch System

      if(Input.touchCount != 1)
      {
        IsTouch = false;
      }

      if(Input.touchCount > 0)
      {
        Touch touch = Input.GetTouch(0);
        if(touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary)
        {
          RaycastHit hit;
          Ray ray = Camera.main.ScreenPointToRay(touch.position); 
          if(Physics.Raycast(ray, out hit, float.MaxValue, FoodSettings.layer))  
          {  
            SelectedObject = hit.collider.gameObject;
            SelectedRigid = hit.collider.gameObject.GetComponent<Rigidbody>();              
            IsTouch = true;                        
          }
        }

        if(touch.phase == TouchPhase.Moved)
        {
          Move.x = Input.GetTouch(0).deltaPosition.x / Screen.width * FoodSettings.DragSpeed * Time.deltaTime;
          Move.z = Input.GetTouch(0).deltaPosition.y / Screen.width * FoodSettings.DragSpeed * Time.deltaTime;
          // Object Rotate
          SelectedObject.transform.Rotate(new Vector3(Input.GetTouch(0).deltaPosition.x, -Input.GetTouch(0).deltaPosition.y, 0f) * Time.deltaTime * FoodSettings.ObjectRotateSpeed);
        }
        
        if(touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
        {
          IsTouch = false; 
          RigidbodyControl = true;         
        }
      }    
                      
      if(IsTouch)
      { 
        // Rigidbody Move        
        SelectedRigid.MovePosition(SelectedRigid.position + Move);
        // Object Height
        SelectedObject.transform.position = new Vector3(SelectedObject.transform.position.x + Move.x, FoodSettings.ObjectHeight, SelectedObject.transform.position.z + Move.z);                                                                     
      }

      if(RigidbodyControl == true)
      {
          SelectedObject.GetComponent<Rigidbody>().drag = 2.5f;
          Invoke("RigidbodyFinish", 1f);
      }
      #endregion
    } 

    public void ObjectLaunching()
    {
       SelectedObject.transform.DOLocalMove(new Vector3(SelectedObject.transform.position.x + Move.x, SelectedObject.transform.position.y + 2f, SelectedObject.transform.position.z + Move.z), 0.3f);
    }
    public void RigidbodyFinish()
    {
        SelectedObject.GetComponent<Rigidbody>().drag = 5; 
        RigidbodyControl = false;
    }
  }   
}
