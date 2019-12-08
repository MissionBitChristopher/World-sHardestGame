using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "enemy1" || this.gameObject.name == "enemy3")
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        else {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    { 
        if(collision.gameObject.name == "player") {
            player.transform.position = new Vector3(-5.68f, 2.2f, 0);
        }
        else {
            speed *= -1;
        }
    }
}
