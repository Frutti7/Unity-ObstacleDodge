using System;
using UnityEngine;
using Unity.Cinemachine;

public class Mover : MonoBehaviour {
    [SerializeField] float moveSpeed = 10.0f;

    //[SerializeField] private CinemachineCamera cinemachine;
    //private CinemachineFollow compo;
    private Rigidbody rb;

    void Start() {
        //compo = cinemachine.GetComponent<CinemachineFollow>();
        rb = GetComponent<Rigidbody>();
    }


    void Update() {
        MovePlayer();
        //compo.FollowOffset.y += 0.02f;
    }

    void PrintInstruction() {
        Debug.Log("Use WASD to move");
    }

    void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.00f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }


    void FixedUpdate() {
        /*
        // Using Rigidbody is the way to do it for making the engine work properly.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        rb.linearVelocity = new Vector3(
            movement.x * moveSpeed,
            rb.linearVelocity.y,
            movement.z * moveSpeed
        );
        */
    }
}