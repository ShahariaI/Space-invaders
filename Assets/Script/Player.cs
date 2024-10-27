using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    public Laser laserPrefab;
    Laser laser;
    float speed = 5f;
    public int Lives = 3;
    public Image[] LivesUI;
    
    public bool isDead;

    public int laserAmount = 1;
    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed * Time.deltaTime;
        }

        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space) && laser == null)
        {
            StartCoroutine(SpawnLaser());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Missile") || collision.gameObject.layer == LayerMask.NameToLayer("Invader"))
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Missile"))
            {

                Destroy(collision.gameObject);
                Lives -= 1;

                    
                if (Lives <= 0 && !isDead)
                {
                    isDead = true;
                    GameManager.Instance.GameOver();
                    
                    Destroy(gameObject);
                    

                }

            }
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("PowerUp"))
        {
            if (collision.gameObject.name == "PowerUp1(Clone)")
            {
                laserAmount++;
                // �kar m�ngden lasers man skuter
            }
            if(collision.gameObject.name == "PowerUp2(Clone)")
            {
                // den h�r powerup ska dubbla de points man f�r men �r inte klar
            }
        }
    }
    IEnumerator SpawnLaser()
    {
        for (int l = 0; l < laserAmount; l++)
        {
            laser = Instantiate(laserPrefab, gameObject.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
            //Instantiatar en laser och om den inte �r upe i ens max antal lasrar s� v�ntar den och skuter sen en till
        }
    }
}
