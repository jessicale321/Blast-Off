using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMvmt : MonoBehaviour
{

    [SerializeField] float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            if (transform.position.x > -7.35) {
                transform.Translate(speed * Vector2.left * Time.deltaTime);
            }
            
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            if (transform.position.x < 7.35) {
                transform.Translate(speed * Vector2.right * Time.deltaTime);
            }
            
        }
    }

}
