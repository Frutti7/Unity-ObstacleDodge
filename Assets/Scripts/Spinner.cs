using System;
using UnityEngine;

public class Spinner : MonoBehaviour {
   [SerializeField] private float rotateSpeedX = 0f;
   [SerializeField] private float rotateSpeedY = 1f;
   [SerializeField] private float rotateSpeedZ = 0f;
   private void Update() {
      this.transform.Rotate(rotateSpeedX, rotateSpeedY, rotateSpeedZ);
   }
}
