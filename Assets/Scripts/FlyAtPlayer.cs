using System;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour {
    
    Vector3 direction;
    [SerializeField] Transform player;
    [SerializeField] float speed = 0.1f;
    Vector3 playerPosition;

    private void Start() {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerPosition = player.transform.position;
        direction = (player.position - transform.position).normalized;
    }

    private void Update() {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.TryGetComponent<IProjectileInterceptor>(out var interceptor))
        {
            interceptor.InterceptProjectile(gameObject);
        }
    }
}