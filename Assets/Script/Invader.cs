using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]

public class Invader : MonoBehaviour
{
    public PointManager pointManager;
    public Sprite[] animationSprites = new Sprite[2];
    public float animationTime;

    SpriteRenderer spRend;
    int animationFrame;
    // Start is called before the first frame update

    private void Awake()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        spRend = GetComponent<SpriteRenderer>();
        spRend.sprite = animationSprites[0];
    }

    void Start()
    {
        //Anropar AnimateSprite med ett visst tidsintervall
        InvokeRepeating( nameof(AnimateSprite) , animationTime, animationTime);
    }

    //pandlar mellan olika sprited f�r att skapa en animation
    private void AnimateSprite()
    {
        animationFrame++;
        if(animationFrame >= animationSprites.Length)
        {
            animationFrame = 0;
        }
        spRend.sprite = animationSprites[animationFrame];
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        

        if (collision.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            if (gameObject.TryGetComponent(out DropPowerUp component))
            {
                component.SpawnPowerUp(gameObject.transform.position.x, gameObject.transform.position.y);
            }

            GameManager.Instance.OnInvaderKilled(this);
            pointManager.UpdateScore(50);
        }

        else if(collision.gameObject.layer == LayerMask.NameToLayer("Boundary")) //n�tt nedre kanten
        {
            GameManager.Instance.OnBoundaryReached();
        }

    }

}
