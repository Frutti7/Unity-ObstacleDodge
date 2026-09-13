using System;
using Unity.Cinemachine;
using UnityEngine;

public class Scorer : MonoBehaviour {
    private int bumTimes = 0;


    void Start() {
        //ObjectHit.onCollision += ObjectHit_onCollision;
    }

    private void ObjectHit_onCollision(object sender, EventArgs e) {
        //bumTimes++;
    }


    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Hit") {
            bumTimes++;
            Debug.Log("We bumped into something this many times: " + bumTimes);
        }
    }
}