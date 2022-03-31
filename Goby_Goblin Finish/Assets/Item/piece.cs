using UnityEngine;

public class piece : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {            

        if (collision.CompareTag("Player"))
        {
            inventory.instance.AddCoins(1);
            Destroy(gameObject);
        }
    }
}
