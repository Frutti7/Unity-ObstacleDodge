using UnityEngine;
using Unity.Cinemachine;

public class Mover : MonoBehaviour {
    [SerializeField] float moveSpeed = 10.0f;
    //[SerializeField] private CinemachineCamera cinemachine;
    //private CinemachineFollow compo;
    
    void Start() {
        //compo = cinemachine.GetComponent<CinemachineFollow>();
    }


    void Update() {
    
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    float yValue = 0.00f;
    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    transform.Translate(xValue, yValue, zValue);
    //compo.FollowOffset.y += 0.02f;
    }
    
    
}