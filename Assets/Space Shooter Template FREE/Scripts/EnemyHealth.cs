using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Chỉ xử lý khi bị đạn Player bắn trúng
        if (!collision.CompareTag("Bullet")) return;

        // Spawn explosion
        if (explosionPrefab != null)
        {
            var ex = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(ex, 1f);
        }

        // Destroy bullet + enemy
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
