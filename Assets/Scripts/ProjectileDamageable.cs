using UnityEngine;

public class ProjectileDamageable : MonoBehaviour, IProjectileInterceptor
{
    public void InterceptProjectile(GameObject projectile)
    {
        TakeDamage();
        projectile.SetActive(false);
    }

    private void TakeDamage()
    {
        Debug.Log("I took damage!");
    }
}
