using UnityEngine;

public class EnemyAutoShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float firstShotDelay = 0.5f;
    public float shootInterval = 1.0f;

    private void Start()
    {
        InvokeRepeating(nameof(Shoot), firstShotDelay, shootInterval);
    }

    private void Shoot()
    {
        if (projectilePrefab == null) return;
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
