using UnityEngine;

public class ProjectileDestroyer : MonoBehaviour, IProjectileInterceptor {
   public void InterceptProjectile(GameObject projectile) {
      Debug.Log("Projectile Destroyed");
      Destroy(projectile);
   }  
}
