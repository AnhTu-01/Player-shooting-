using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float flySpeed = 4f;
    public int damage = 1;

    void Update()
    {
        var pos = transform.position;
        pos.y -= flySpeed * Time.deltaTime;   // bay xuống
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
