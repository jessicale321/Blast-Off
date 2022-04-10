using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Obstacle") && PlayerHit.health <= 0) {
            LevelManager.instance.Respawn();
            Destroy(gameObject);
        }
    }


    
}
