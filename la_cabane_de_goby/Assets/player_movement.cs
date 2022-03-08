using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    Rigidbody2D rb2D;
    public float speed;
    public Vector2 move;


    // Start is called before the first frame update
    void Awake()
    {
        // Declare Rigidbody2D
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        // Get Input
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        // Define horizontal movement according to input
        float horizontal;
        horizontal = (move.x * (speed * Time.deltaTime));

        // Define vertical movement according to input
        float vertical;
        vertical = (move.y * (speed * Time.deltaTime));

        // Apply movement input to velocity
        rb2D.velocity = new Vector2(horizontal, vertical);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger!");
    }
}
