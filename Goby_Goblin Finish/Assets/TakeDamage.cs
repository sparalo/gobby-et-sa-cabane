using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int maxHealth = 2;
    public int currentHealth;

    public LayerMask bulletLayer;
    public float hitBoxRadius;
    public bool canBeHit;
    public float recoveryTime;
    float time;

    public void Start()
    {
        currentHealth = maxHealth;
    }
    public void Update()
    {

        if (Physics2D.OverlapCircle(transform.position, hitBoxRadius, bulletLayer) && canBeHit)
        {
            TakeADamage(1);
            canBeHit = false;
            time = 0;
        }

        Recovery();

        if (currentHealth <= 0) Destroy(transform.root.gameObject);
    }

    void Recovery()
    {
        if (!canBeHit) time += Time.deltaTime;
        if (time > recoveryTime) canBeHit = true;
    }

    public void TakeADamage(int damage)
    {
        currentHealth -= damage;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, hitBoxRadius);
    }
}
