using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]



public class Laser : Projectile
{
   
    private void Awake()
    {
        direction = Vector3.up;
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * direction;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CheckCollision(collision);
    }

    void CheckCollision(Collider2D collision)
    {
        Bunker bunker = collision.gameObject.GetComponent<Bunker>();
        PowerUp powerUp = collision.gameObject.GetComponent<PowerUp>();
        Laser laser = collision.gameObject.GetComponent<Laser>();
        if(bunker == null && powerUp == null && laser == null) //Om det inte är en bunker eller en powerup vi träffat så ska skottet försvinna.
        {
            Destroy(gameObject);
        }
    }
}
