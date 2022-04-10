using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHit : MonoBehaviour
{
    public int health = 20;
    float colorTime = 1f;
    float currentTime;
    public Text healthText;
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
            //end game
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
