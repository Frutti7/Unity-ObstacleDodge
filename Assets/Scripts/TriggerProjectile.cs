using System;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour {
    [SerializeField] GameObject[] projectile;
    private bool isTriggered = false;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && !isTriggered) {
            foreach (var p in projectile) {
                if (p != null) {
                    p.SetActive(true);
                }
            }

            isTriggered = true;
        }
    }
}