using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryFeedback : MonoBehaviour
{
    SpriteRenderer sprite;
    TakeDamage takeDamage;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        takeDamage = GetComponent<TakeDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!takeDamage.canBeHit)
        {
            sprite.color = Color.grey;
        }
        else
        {
            sprite.color = Color.white;
        }
    }
}
