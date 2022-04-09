using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMvmt : MonoBehaviour
{
    [SerializeField] Vector2 playerSpeed = new Vector2(10, 0);
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            movePlayer(-1);
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            movePlayer(1);
        }
    }

    void movePlayer(int direction)
    {
        rb.MovePosition(rb.position + direction * (playerSpeed * Time.deltaTime));
    }
}
