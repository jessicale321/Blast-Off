using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    GameObject bulletInstance;
    [SerializeField] public float offset = 0.75f;
    void Awake() {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bulletInstance = Instantiate(bulletPrefab, transform.position + (transform.up * offset), transform.rotation) as GameObject;
        }
    }

}
