using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 3f; 
    void Update() {
        
        if (Time.time > timeToDrop) {
            Debug.Log("Dropped");
        }
      
   }
}
