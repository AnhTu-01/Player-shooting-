using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();

        if (GameManager.instance != null)
            GameManager.instance.GameOver();
    }
}
