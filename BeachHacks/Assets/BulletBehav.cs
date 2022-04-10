using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehav : MonoBehaviour
{
    [SerializeField] float speed = 4.5f;
    [SerializeField] int damage = 2;
    private Rigidbody2D rb;
    public bool collided = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //rb.MovePosition(rb.position + Vector2.up * Time.deltaTime * speed);
    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + Vector2.up * Time.deltaTime * speed);
        if (transform.position.y > 5) {
            if (gameObject != null) {
            Destroy(gameObject);
        }
        }
        //transform.Translate(0, speed * Time.deltaTime, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        ObstacleHit obstacle = other.gameObject.GetComponent<ObstacleHit>();
        if (obstacle != null) {
            obstacle.TakeDamage(damage);
        }
        // https://www.youtube.com/watch?v=oDtAOpBlTAo
        Debug.Log("hit");
        collided = true;
        
        if (gameObject != null) {
            Destroy(gameObject);
        }
        
    }
}
