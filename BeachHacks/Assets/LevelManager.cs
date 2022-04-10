using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public Transform respawnPoint;
    public GameObject playerPrefab;
    Transform player;

    private void Awake() { // make this accessible from outside
        instance = this;
    }

    public void Respawn(){
        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        //playerPrefab.transform.position = respawnPoint.transform.position;
    }
}
