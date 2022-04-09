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
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.MovePosition(rb.position + Vector2.up * Time.deltaTime * speed);
    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + Vector2.up * Time.deltaTime * speed);
        //transform.Translate(0, speed * Time.deltaTime, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Obstacle obstacle = other.gameObject.GetComponent<Obstacle>();
        if (obstacle != null) {
            obstacle.TakeDamage(damage);
        }
        // https://www.youtube.com/watch?v=oDtAOpBlTAo
        Debug.Log("hit");
        collided = true;
        
        Destroy(gameObject);
    }
}
