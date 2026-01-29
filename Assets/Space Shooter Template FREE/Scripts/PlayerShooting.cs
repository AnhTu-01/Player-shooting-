using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval = 0.1f;

    // ✅ Part 3: đẩy điểm sinh đạn lên "mũi" máy bay
    public Vector3 bulletOffset = new Vector3(0f, 0.6f, 0f);

    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        Instantiate(
            bulletPrefabs,
            transform.position + bulletOffset,
            transform.rotation
        );
    }
}
