using System;
using System.Linq;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectHit : MonoBehaviour {
    public static event EventHandler onCollision;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            GetComponent<MeshRenderer>().material.color = Color.black;
            if (gameObject.tag != "Hit") {
                //onCollision?.Invoke(this, EventArgs.Empty);
            }
            gameObject.tag = "Hit";
        }
    }
}