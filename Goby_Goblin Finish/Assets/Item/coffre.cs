using UnityEngine;
using UnityEngine.UI;

public class coffre : MonoBehaviour
{
    private Text interactUI;
    [SerializeField] bool isInRange = false;
    public float range;
    public LayerMask whatIsPlayer;
    public int Argent;

    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            isInRange = true;
            Debug.Log("Open");
        }
        else
        {
            isInRange = false;
            Debug.Log("Close");

        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isInRange)
        {
            Debug.Log("E");
            OpenCoffre();
        }
    }

    void OpenCoffre()
    {
        inventory.instance.AddCoins(Argent);
        Destroy(gameObject);
        Debug.Log("Coffre Detruit");
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }


}



