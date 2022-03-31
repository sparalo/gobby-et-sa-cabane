using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class potion : MonoBehaviour
{
    private Text interactUI;
    [SerializeField] bool isInRange;
    public float range;
    public LayerMask whatIsPlayer;
    public int Potion;
    public int Argent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isInRange)
        {
            Debug.Log("E");
            buyPotion();
        }

        if (Physics2D.OverlapCircle(transform.position, range, whatIsPlayer))
        {
            isInRange = true;
        } else isInRange = false;

    }
    void buyPotion()
    {
        if (inventory.instance.coinsCount >= 50)
        {
            inventory.instance.MinCoins(Argent);
            inventory.instance.AddPotion(Potion);
            Destroy(gameObject);
            Debug.Log("Potion acheté");
        }
        else
        {
            return;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}