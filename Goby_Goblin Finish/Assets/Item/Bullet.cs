using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public LayerMask whatDestroysBullet;
    public GameObject hitEffect;
    public float radius;
    public float timeBeforeDead;
    float time;

    private void Update()
    {
        if (time > timeBeforeDead)
        {
            Destroy(gameObject);
            Debug.Log("Bam");
        }
        time += Time.deltaTime;


        if (Physics2D.OverlapCircle(transform.position, radius, whatDestroysBullet))
        {
            Debug.Log("Boom");
            //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            //Destroy(effect, 5f);
            Destroy(gameObject);
        }
    }

}
