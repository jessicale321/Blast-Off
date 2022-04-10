using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    [SerializeField] int damage = 4;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + Vector2.down * Time.deltaTime * speed);
        if (transform.position.y < -6) {
            if (gameObject != null) {
            Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        PlayerHit player = other.gameObject.GetComponent<PlayerHit>();
        if (player != null) {
            player.TakeDamage(damage);
            if (gameObject != null) {
            Destroy(gameObject);
        }
        }

        
    }
}
