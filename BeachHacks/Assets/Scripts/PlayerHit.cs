using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    public static int health = 20;
    float colorTime = 1f;
    float currentTime;
    public Text healthText;
    [SerializeField] public Transform respawnPoint;
    public GameObject playerPrefab;
    [SerializeField] Transform player;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health.ToString();
    }

    public void TakeDamage(int damage) 
    {
        health -= damage;
        //gameObject.GetComponent<Renderer>().material.color = Color.red;
        //colorWait();
        // gameObject.GetComponent<Renderer>().material.color = Color.white;
        
        if (health <= 0) {
            // Destroy(gameObject);
            // LevelManager.instance.Respawn();
            health = 20;
            PlayerShoot.bulletAmt = 10;
            // player.position = new Vector2(respawnPoint.position.x, respawnPoint.position.y);
            //FindObjectOfType<LevelManager>().Respawn();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }

    // color changing fail
    IEnumerator colorWait()
    {
        Debug.Log("change to white");
        yield return new WaitForSeconds(5);
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    
}
