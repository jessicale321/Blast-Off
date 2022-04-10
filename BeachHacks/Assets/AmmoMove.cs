using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoMove : MonoBehaviour
{
    [SerializeField] float speed = 3f;
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
        PlayerShoot player = other.gameObject.GetComponent<PlayerShoot>();
        if (player != null) {
            PlayerShoot.addAmmo(1);
        }

        if (gameObject != null) {
            Destroy(gameObject);
        }
    }
}
