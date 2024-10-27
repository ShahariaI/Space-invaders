using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Projectile
{
    private void Awake()
    {
        direction = Vector3.down;
    } 

    void Update()
    {
        transform.position += speed * Time.deltaTime * direction;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            Destroy(gameObject);
        }

    }
}
