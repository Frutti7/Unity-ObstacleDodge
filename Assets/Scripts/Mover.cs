using UnityEngine;

public class Mover : MonoBehaviour {
    [SerializeField] float moveSpeed = 10.0f;
    
    void Start() {
    }


    void Update() {
    
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    float yValue = 0.00f;
    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    transform.Translate(xValue, yValue, zValue);
    }
}