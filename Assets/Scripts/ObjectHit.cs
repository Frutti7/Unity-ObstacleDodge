using System;
using System.Linq;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.EventSystems;

// Handles interactions when the player collides with this object.
// Changes its appearance and marks it as "Hit".
public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.black;

            if (gameObject.tag != "Hit")
            {
                // Trigger an event here when the object is hit for the first time.
            }

            gameObject.tag = "Hit";
        }
    }
}