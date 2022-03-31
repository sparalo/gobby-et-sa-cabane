using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public LayerMask enemyLayer;
    public float hitBoxRadius;
    public bool canBeHit;
    public float recoveryTime;
    float time;
    SpriteRenderer sprite;
    public HealthBar_Script healthBar;

    public void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void Update()
    {

        if (Physics2D.OverlapCircle(transform.position, hitBoxRadius, enemyLayer) && canBeHit)
        {
            TakeDamage(20);
            canBeHit = false;
            time = 0;
        }

        Recovery();

        if (!canBeHit)
        {
            sprite.color = Color.grey;
        }
        else
        {
            sprite.color = Color.white;
        }
    }

    void Recovery()
    {
        if (!canBeHit) time += Time.deltaTime;
        if (time > recoveryTime) canBeHit = true;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, hitBoxRadius);
    }

}
