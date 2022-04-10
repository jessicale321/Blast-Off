
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    public LevelManager levelManager;
    private Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + Vector2.down * Time.deltaTime * speed);
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        levelManager.EndGame();
    }
}
